using BilgeHotel.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Features.Reservation.Commands.Create
{
    public class CreateReservationCommandResponse : SingleResponseParameters
    {
        /// <summary>
        /// indirimsiz fiyat
        /// </summary>
        public decimal? RealPrice { get; set; }
        /// <summary>
        /// indirimli fiyat
        /// </summary>
        public decimal? TotalPrice { get; set; }
        /// <summary>
        /// indirim oranı
        /// </summary>
        public decimal? RefuendedPrice { get; set; }
    }
}
