using BilgeHotel.Application.Features.EmployeePrice.Commands.Delete;
using BilgeHotel.Application.Features.Reservation.Commands.Create;
using BilgeHotel.Application.Repositories.EmployeePriceRepositories;
using BilgeHotel.Application.Repositories.ReservationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Delete
{
    public class DeleteReservationCommandHandler : IRequestHandler<DeleteReservationCommandRequest, DeleteReservationCommandResponse>
    {
        private readonly IReservationWriteRepository _reservationWriteRepository;
        private readonly IReservationReadRepository _reservationReadRepository;
        public DeleteReservationCommandHandler(IReservationWriteRepository reservationWriteRepository, IReservationReadRepository reservationReadRepository)
        {
            _reservationWriteRepository = reservationWriteRepository;
            _reservationReadRepository = reservationReadRepository;
        }
        public async Task<DeleteReservationCommandResponse> Handle(DeleteReservationCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _reservationReadRepository.GetByIdAsync(request.Id);
            if (entity == null) { return new DeleteReservationCommandResponse { Message = "bulunamadı" }; }
            entity.IsDeleted = true;
            entity.IsPassive = true;
            var update = await _reservationWriteRepository.Update(entity);
            var save = await _reservationWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new DeleteReservationCommandResponse { Message = "kaydederken hata" };
            }
            if (update)
            {
                return new DeleteReservationCommandResponse { Message = "başarılı" };
            }
            else
            {
                return new DeleteReservationCommandResponse { Message = "hata" };
            }
        }
    }
}
