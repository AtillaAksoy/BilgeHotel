using BilgeHotel.Application.Repositories.ImageRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Image.Commands.Delete
{
    public class DeleteImagePathCommandHandler : IRequestHandler<DeleteImagePathCommandRequest, DeleteImagePathCommandResponse>
    {
        private readonly IImageWriteRepository _imageWriteRepository;
        private readonly IImageReadRepository _imageReadRepository;
        public DeleteImagePathCommandHandler(IImageWriteRepository imageWriteRepository, IImageReadRepository imageReadRepository)
        {
            _imageWriteRepository = imageWriteRepository;
            _imageReadRepository = imageReadRepository;
        }
        public async Task<DeleteImagePathCommandResponse> Handle(DeleteImagePathCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _imageReadRepository.GetByIdAsync(request.ImageId);
            if (entity == null) { return new DeleteImagePathCommandResponse { Message = "fotoğraf bulunamadı" }; }
            entity.IsDeleted = true;
            entity.IsPassive = true;
            var update = await _imageWriteRepository.Update(entity);
            var save = await _imageWriteRepository.SaveAsync();
            if (update!= true || save != 1)
            {
                return new DeleteImagePathCommandResponse { Message = "hata" };
            }
            return new DeleteImagePathCommandResponse { Message = "başarılı" };
        }
    }
}
