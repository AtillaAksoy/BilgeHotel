using BilgeHotel.Application.Features.Room.Commands.UpdateRoomByStateForEmployee;
using BilgeHotel.Application.Repositories.CustomerRepositories;
using BilgeHotel.Application.Repositories.MailService;
using BilgeHotel.Application.Repositories.ReservationRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.UpdateReservationByStateForReceptionist
{
    public class UpdateReservationByStateCommandHandler : IRequestHandler<UpdateReservationByStateCommandRequest, UpdateReservationByStateCommandResponse>
    {
        private readonly IReservationWriteRepository _reservationWriteRepository;
        private readonly IMediator _mediator;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IMailService _mailService;

        private readonly IReservationReadRepository _reservationReadRepository;
        public UpdateReservationByStateCommandHandler(IReservationWriteRepository reservationWriteRepository, IReservationReadRepository reservationReadRepository, IMediator mediator, IMailService mailService, ICustomerReadRepository customerReadRepository)
        {
            _reservationWriteRepository = reservationWriteRepository;
            _reservationReadRepository = reservationReadRepository;
            _mediator = mediator;
            _mailService = mailService;
            _customerReadRepository = customerReadRepository;
        }
        public async Task<UpdateReservationByStateCommandResponse> Handle(UpdateReservationByStateCommandRequest request, CancellationToken cancellationToken)
        {
            var reservation = await _reservationReadRepository.GetByIdAsync(request.ReservationId);
            if (reservation == null) { return new UpdateReservationByStateCommandResponse { Message = "rezervasyon bulunamadı" }; }
            if (request.IsPayyed != true)
            {
                return new UpdateReservationByStateCommandResponse { Message = "Ödeme alınmadan İşlem devam edemez" };
            }
            switch (request.StateId)
            {
                case 2:
                    var room = new UpdateRoomByStateForEmployeeCommandRequest { StateId = 3, RoomId = reservation.RoomId };
                    if (request.IsFault == true)
                    {
                        room.StateId = 4;
                    }
                    //oda durumu değiştir 
                    var roomState = await _mediator.Send(room);
                    if (roomState.Message != "başarılı")
                    {
                        string addMessage = roomState.Message;
                    }
                    //muhasebe mail  gönder
                    var mailMessage = $" rezervasyon numarası : {reservation.Id} " +
                        $" rezervasyondan alınan ücret : {reservation.TotalPrice}" +
                        $"rezervasyonun gerçek ücreti : {reservation.RealPrice}" +
                        $"rezervasyonun indirim oranı : {reservation.RefuendedPrice} ";
                    await _mailService.SendMessageAsync("atilla.aksoy.tc@gmail.com", "muhasebeye mail", mailMessage);
                    //rezervasyonu ispassive al
                    reservation.IsPassive = true;
                    reservation.ReservationStateId = request.StateId;
                    var updater = await _reservationWriteRepository.Update(reservation);
                    var saver = await _reservationWriteRepository.SaveAsync();
                    if (updater != true || saver != 1)
                    {
                        return new UpdateReservationByStateCommandResponse { Message = "Hata" };
                    }
                    return new UpdateReservationByStateCommandResponse { Message = "başarılı" };
                    break;
                case 3:
                case 4:
                    if (string.IsNullOrEmpty(request.Description))
                    {
                        return new UpdateReservationByStateCommandResponse { Message = "Açıklama eklemeden işleme devam edemezsiniz" };
                    }
                    reservation.IsDeleted = true;
                    reservation.IsPassive = true;
                    reservation.ReservationStateId = request.StateId;
                    var update = await _reservationWriteRepository.Update(reservation);
                    var save = await _reservationWriteRepository.SaveAsync();
                    if (update!=true || save != 1)
                    {
                        return new UpdateReservationByStateCommandResponse { Message = "Hata" };
                    }
                    break;
                    case 5:
                    case 6://5 ve 6 rezervasyon başladı ise
                    reservation.ReservationStateId = request.StateId;
                    var customer = await _customerReadRepository.GetByIdAsync(reservation.CustomerId);
                    if (customer == null) { throw new Exception("müşteri bulunamadı"); }
                    else
                    {
                        //valiliğe mail gönder 
                        var mailMessage2 = $" müşteri ismi : {customer.FirstName} " +
                       $" müşteri soy ismi : {customer.LastName}" +
                       $"müşteri tc kimlik no : {customer.IdentificationNumber}" +
                       $"müşteri telefon no : {customer.PhoneNumber} " +
                       $"müşteri email adresi : {customer.Email}" +
                       $"müşterinin rezervasyonunun başladığı tarih : {reservation.StartDate}" +
                       $"müşterinin rezervasyonunun bittiği tarih :{reservation.EndDate}";
                        await _mailService.SendMessageAsync("atilla.aksoy.tc@gmail.com", "valiliğe mail", mailMessage2);
                    }
                    var updated = await _reservationWriteRepository.Update(reservation);
                    var saved = await _reservationWriteRepository.SaveAsync();
                    if (updated != true || saved != 1)
                    {
                        return new UpdateReservationByStateCommandResponse { Message = "Hata" };
                    }
                    return new UpdateReservationByStateCommandResponse { Message = "başarılı" };
                    break; 
            }
            return new UpdateReservationByStateCommandResponse { Message = "Geçersiz StateId" };
        }
    }
}
