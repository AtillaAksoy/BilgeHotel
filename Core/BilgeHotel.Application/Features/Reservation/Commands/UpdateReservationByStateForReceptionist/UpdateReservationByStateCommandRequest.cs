using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.UpdateReservationByStateForReceptionist
{
    public class UpdateReservationByStateCommandRequest : IRequest<UpdateReservationByStateCommandResponse>
    {
        public int ReservationId { get; set; }
        /// <summary>
        /// resepsiyonist gelen müşterinin adından listede arama yapar ve bulunan rezervasyonun durumunu değiştirir eğer iptal ise ödemeli iptal veya ödemesiz iptal i seçer ve ıd si stateId ye gönderilir eğer tamamlandı ise tamamlandıya tıklar ve ıd 2 olarak gönderilir böylece rezervasyonun stati 2 ye (tamamlandı) ya çekilir ve IsPassive i true ya döner eğer iptallerden herhangi biri ise ispassive ve isdeleted true ya döner 
        /// ilk rezervasyon oluşturulurken ıd ya 1 yada 5 olarak gönderilir müşteri internetten rezervasyon oluşturuyorsa 4 olarak gider (ödemesi alınmadı planlandı) eğer resepsiyondan oluşturuluyorsa ek olarak oluşturan kişinin(employee) ıd si de gider ve ıd employeeId ye atanır ve ödeme yaparsa state 1 olarak girilir planladı ödemesi alındı eğer ödemeyi yapmaz ise 4 olarak ataır 
        /// </summary>
        public int StateId { get; set; }
        /// <summary>
        /// eğer müşteri resepsiyoniste odada arıza olduğunun bilgisini verirse resepsiyonist IsFault u true girer ve odanın durumu arızalıya çekilir
        /// </summary>
        public bool? IsFault { get; set; }

        public string? Description { get; set; }
        /// <summary>
        /// ekranda rezervasyonun state i 1 değilse veya IsPayyed ı false veya null ise ekranda uyarı verecek ve burayı doldurması gerekecek resepsiyonistin
        /// </summary>
        public bool? IsPayyed { get; set; }
    }
}
