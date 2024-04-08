using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Employee.Queries.GetById
{
    public class GetEmployeeByIdQueryRequest : IRequest<GetEmployeeByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
