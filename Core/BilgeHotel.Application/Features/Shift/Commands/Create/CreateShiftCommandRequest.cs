using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Commands.Create
{
    public class CreateShiftCommandRequest : IRequest<CreateShiftCommandResponse>
    {
        public ShiftDto Shift {get; set; }
    }
}
