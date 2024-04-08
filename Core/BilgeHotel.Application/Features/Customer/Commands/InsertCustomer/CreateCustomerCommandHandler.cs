using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Repositories.CustomerRepositories;
using BilgeHotel.Domain.Entities;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Customer.Commands.InsertCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommandRequest, CreateCustomerCommandResponse>
    {
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public CreateCustomerCommandHandler(ICustomerWriteRepository customerWriteRepository)
        {
            _customerWriteRepository = customerWriteRepository;
        }
        public async Task<CreateCustomerCommandResponse> Handle(CreateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var response = new CreateCustomerCommandResponse();
            try
            {
                var data = request.Customer.Adapt<BilgeHotel.Domain.Entities.Customer>();
                var result = await _customerWriteRepository.AddAsync(data);
                var save = await _customerWriteRepository.SaveAsync();
                if (save == 0)
                {
                    response.Message = "Kaydeterken hata";
                    return response;
                }
                if (result == true)
                {
                    response.Message = "Başarılı";
                    //if (data.Id != null)
                    //{
                    //    response.Id = data.Id;
                    //} //burada addasync methoduna geri dönüş tipi ekleyerek ıd yi yakalayabilir geri döndürebiliriz 
                    return response;
                }
                else
                {
                    response.Message = "Insert Ederken hata";
                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Message = $"Hata {ex.Message}";
                return response;
            }
            
        }
    }
}
