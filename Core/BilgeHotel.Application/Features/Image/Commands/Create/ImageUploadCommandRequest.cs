using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Image.Commands.Create
{
    public class ImageUploadCommandRequest : IRequest<ImageUploadCommandResponse>
    {
        public int RoomId { get; set; }
        public string ImagePath { get; set; }

        public IFormFile RoomImage { get; set; }
    }
}
