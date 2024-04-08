using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Image.Commands.Delete
{
    public class DeleteImagePathCommandRequest : IRequest<DeleteImagePathCommandResponse>
    {
        public int ImageId { get; set; }
    }
}
