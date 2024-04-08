using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Repositories.MailService;
using BilgeHotel.Domain.Entities;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BilgeHotel.Application.Features.Employee.Queries.GetPagedList
{
    public class EmployeeGetPagedListQueryHandler : IRequestHandler<EmployeeGetPagedListQueryRequest, EmployeeGetPagedListQueryResponse>
    {
        private readonly UserManager<BilgeHotel.Domain.Entities.Identity.Employee> _userManager;
        private readonly IMailService _mailService;
        public EmployeeGetPagedListQueryHandler(UserManager<Domain.Entities.Identity.Employee> userManager, IMailService mailService)
        {
            _userManager = userManager;
            _mailService = mailService;
        }

        public async Task<EmployeeGetPagedListQueryResponse> Handle(EmployeeGetPagedListQueryRequest request, CancellationToken cancellationToken)
        {
            try
            {
                //var allEmployees = _userManager.Users.Where(u => u.IsDeleted == false);
                var allEmployees = _userManager.Users
                                    .Include(u => u.Roles)
                                    .Include(u => u.Reservations)
                                    .Include(u => u.EmployeePrices.Where(ep => ep.IsDeleted == false))
                                    .Include(u => u.Shifts.Where(s => s.IsDeleted == false))
                                    .Where(u => u.IsDeleted == false);

                var totalCount = allEmployees.Count();

                if (!string.IsNullOrEmpty(request.SearchValue))
                {
                    allEmployees = allEmployees.Where(u => u.UserName.Contains(request.SearchValue));
                }

                var filteredCount = totalCount;

                var employees = allEmployees
                    .Skip((request.Start ?? 0))
                    .Take((request.End ?? 50))
                    .ToList()
                    .Adapt<List<EmployeeDto>>();

                var now = DateTime.Now;
                var firstDayOfMonth = new DateTime(now.Year, now.Month, 1);
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

                int daysInMonth = DateTime.DaysInMonth(now.Year, now.Month);

                foreach (var item in employees)
                {
                    decimal employeprice;
                    decimal hoursDecimal = 9;//10 ile 8 arası
                    foreach (var s in item.Shifts)
                    {
                     var difference =  s.EndTime - s.StartTime;
                        double totalHours = difference.TotalHours;
                        hoursDecimal = Convert.ToDecimal(totalHours);
                        break;
                    }
                    foreach (var ep in item.EmployeePrices)
                    {
                        employeprice = ep.Price;
                        if (ep.PriceTypeId == 1)
                        {
                            item.TotalEarnings = (employeprice * hoursDecimal) * daysInMonth;
                        }
                        if (ep.PriceTypeId == 2)
                        {
                            item.TotalEarnings = employeprice * daysInMonth;
                        }
                        if (ep.PriceTypeId == 3)
                        {
                            item.TotalEarnings = employeprice;
                        }
                    }
                }

                //eğer gün lastDayOfMonth ' a eşit ise mail gönder muhasebe ye
                if (DateTime.Now == lastDayOfMonth)
                {
                    foreach (var item in employees)
                    {
                        var mailMessage = $" eleman ismi : {item.UserName} " +
                            $"eleman tc kimlik no : {item.IdentificationNumber}" +
                            $"elemanın bu aylık hak edişi : {item.TotalEarnings}" +
                            $"bu ayın tarihi : {DateTime.Now}" +
                            $"Dikkat bu mail tekrarlanabilir tarihleri kontrol ederek yatır" +
                            $""; 
                        await _mailService.SendMessageAsync("atilla.aksoy.tc@gmail.com", "muhasebeye mail", mailMessage);
                    }
                }
                

                return new EmployeeGetPagedListQueryResponse
                {
                    TotalCount = totalCount,
                    FilteredCount = filteredCount,
                    Employees = employees
                };
            }
            catch (Exception ex)
            {
                return new EmployeeGetPagedListQueryResponse { Message = $"Hata oluştu: {ex.Message}" };
            }
        }
        


    }
}
