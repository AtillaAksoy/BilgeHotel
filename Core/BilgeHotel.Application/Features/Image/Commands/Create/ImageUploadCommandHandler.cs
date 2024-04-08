using BilgeHotel.Application.Repositories.ImageHelpers;
using BilgeHotel.Application.Repositories.ImageRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Image.Commands.Create
{
    public class ImageUploadCommandHandler : IRequestHandler<ImageUploadCommandRequest, ImageUploadCommandResponse>
    {
        private readonly IImageUploader _ımageUploader;
        private readonly IImageWriteRepository _ımageWriteRepository;
        public ImageUploadCommandHandler(IImageUploader ımageUploader, IImageWriteRepository ımageWriteRepository)
        {
            _ımageUploader = ımageUploader;
            _ımageWriteRepository = ımageWriteRepository;
        }
        public async Task<ImageUploadCommandResponse> Handle(ImageUploadCommandRequest request, CancellationToken cancellationToken)
        {
            string path = "";

            var imageResult = _ımageUploader.Upload(request.RoomImage.FileName);
            if (imageResult != "0")
            {
                path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\room", imageResult);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await request.RoomImage.CopyToAsync(stream);
                };
                request.ImagePath = imageResult;

                var entity = new Domain.Entities.Image()
                {
                    RoomId = request.RoomId,
                    ImagePath = request.ImagePath
                };
                var add = await _ımageWriteRepository.AddAsync(entity);
                var save = await _ımageWriteRepository.SaveAsync();
                if (add != true || save != 1)
                {
                    return new ImageUploadCommandResponse() { Message = "hata." };
                }
                return new ImageUploadCommandResponse() { Message = "başarılı." };
            }
            else
            {
                return new ImageUploadCommandResponse() { Message = "Görsel formatı uygun değil." };
            }



        }
    }
}
