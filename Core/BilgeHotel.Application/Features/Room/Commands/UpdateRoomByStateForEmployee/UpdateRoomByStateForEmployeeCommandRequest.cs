using BilgeHotel.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Room.Commands.UpdateRoomByStateForEmployee
{
    public class UpdateRoomByStateForEmployeeCommandRequest : IRequest<UpdateRoomByStateForEmployeeCommandResponse>
    {
        /// <summary>
        /// isteğin girildiği sayfa eğer employee rolu resepsiyon gorevlisi ise stateıd ye 3
        /// isteğin girildiği sayfa eğer employee rolu temizlik gorevlisi ise stateıd ye 2
        /// isteğin girildiği sayfa eğer employee rolu elektrik gorevlisi ise stateıd ye 3 
        /// değeri girilir (eğer odada arıza veya bakım gereksinimi varsa temizlikçi veya
        /// resepsiyonist tarafından StateId 4 olarak gönderilir)
        /// eğer kiralama bitmeden oda temizliği algoritması eklensin kim hangi odaları temizlesin bilinsin istenirse ona göre günlük veya haftalık belirli saatler arasında tüm odaların durumu temizlenecek olarak işaretlenir ve temizlendikten sonra eğer boş durumu atanırsa önce aktif rezervasyonu varmı kontrolü yapılır varsa doluda kalmaya devam eder
        /// </summary>
        public int RoomId { get; set; }
        public int StateId { get; set; }
    }
}
