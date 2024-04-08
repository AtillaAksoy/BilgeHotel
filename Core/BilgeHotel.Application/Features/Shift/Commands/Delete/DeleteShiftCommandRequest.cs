using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Shift.Commands.Delete
{
    public class DeleteShiftCommandRequest : IRequest<DeleteShiftCommandResponse>
    {
        public int Id { get; set; }
    }
}
