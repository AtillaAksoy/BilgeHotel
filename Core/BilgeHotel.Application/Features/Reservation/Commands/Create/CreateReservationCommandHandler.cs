using BilgeHotel.Application.Repositories.ReservationRepositories;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Create
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommandRequest, CreateReservationCommandResponse>
    {
        private readonly IReservationWriteRepository _reservationWriteRepository;
        public CreateReservationCommandHandler(IReservationWriteRepository reservationWriteRepository)
        {
            _reservationWriteRepository = reservationWriteRepository;
        }
        public async Task<CreateReservationCommandResponse> Handle(CreateReservationCommandRequest request, CancellationToken cancellationToken)
        {
            var reservation = request.Reservation.Adapt<Domain.Entities.Reservation>();
            reservation.RealPrice = request.TotalPrice;
            // Rezervasyon türüne göre indirim oranını belirle
            decimal discountRate = 0;
            if (reservation.ReservationTypeId == 1) // Tam Pansiyon
            {
                if ((reservation.StartDate -DateTime.Now).TotalDays >= 30)
                {
                    discountRate = 0.16m; // %16 indirim
                }
            }
            else if (reservation.ReservationTypeId == 2) // Herşey Dahil
            {
                if ((reservation.StartDate - DateTime.Now).TotalDays >= 30)
                {
                    discountRate = 0.18m; // %18 indirim
                }
                else if ((reservation.StartDate - DateTime.Now).TotalDays >= 90)
                {
                    discountRate = 0.23m; // %23 indirim
                }
            }
            reservation.RefuendedPrice = discountRate;
            decimal toplamtutar =   request.TotalPrice - (request.TotalPrice * discountRate);
            reservation.TotalPrice = toplamtutar;

            if (reservation.ReservationStateId == 1)
            {
                reservation.IsPayyed = true;
            }
            var result = await _reservationWriteRepository.AddAsync(reservation);
            var save = await _reservationWriteRepository.SaveAsync();
            if (save == 0)
            {
                return new CreateReservationCommandResponse { Message = "kaydederken hata" };
            }
            if (result)
            {
                return new CreateReservationCommandResponse 
                { 
                    Message = "başarılı",
                    TotalPrice = reservation.TotalPrice,
                    RefuendedPrice = reservation.RefuendedPrice,
                    RealPrice = reservation.RealPrice,
                };
            }
            return new CreateReservationCommandResponse { Message = "hata" };
        }
    }
}
