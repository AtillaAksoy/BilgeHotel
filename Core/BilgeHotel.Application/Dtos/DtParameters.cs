using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Dtos
{
    public class DtParameters
    {
        public int? Start {  get; set; }
        public int? End { get; set; }
        public string? SearchValue { get; set; }
        /// <summary>
        /// Id ye göre ilişkili verilerde arama
        /// </summary>
        public int? Id { get; set; }
        public string? StringId { get; set; }
    }
}
