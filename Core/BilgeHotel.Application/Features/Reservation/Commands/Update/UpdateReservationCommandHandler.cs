using BilgeHotel.Application.Features.Reservation.Commands.Create;
using BilgeHotel.Application.Repositories.ReservationRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Update
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommandRequest, UpdateReservationCommandResponse>
    {
        private readonly IReservationWriteRepository _reservationWriteRepository;
        public UpdateReservationCommandHandler(IReservationWriteRepository reservationWriteRepository)
        {
            _reservationWriteRepository = reservationWriteRepository;
        }
        public async Task<UpdateReservationCommandResponse> Handle(UpdateReservationCommandRequest request, CancellationToken cancellationToken)
        {
            var reservation = request.Reservation.Adapt<Domain.Entities.Reservation>();
            var update = await _reservationWriteRepository.Update(reservation);
            var save = await _reservationWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new UpdateReservationCommandResponse { Message = "kaydederken hata" };
            }
            if (update)
            {
                return new UpdateReservationCommandResponse { Message = "başarılı" };
            }
            return new UpdateReservationCommandResponse { Message = "hata" };
        }
    }
}
