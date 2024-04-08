using BilgeHotel.Application.Dtos;
using BilgeHotel.Application.Features.Customer.Commands.InsertCustomer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Commands.Create
{
    public class CreateEmployeeCommandRequest : IRequest<CreateEmployeeCommandResponse>
    {
        public EmployeeCreateDto employee {  get; set; }
    }
}
