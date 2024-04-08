using BilgeHotel.Domain.Entities.Common;
using BilgeHotel.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Domain.Entities
{
    public class Shift:BaseEntity
    {
        //public int ShiftId { get; set; }  baseIntIdEntity den gelen createdDate propertysi ignore edilecek
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime? RealStartDate { get; set; }//çalışan işe geç geldi ise doldurulacak
        public DateTime? RealEndDate { get; set; }//çalışan işten erken çıktı ise doldurulacak 
        //gelmedi ise gün sonunda gelmedi seçilecek 
        //güncellemeler gün bitmiş olsa bile muhasebe ekranına düşecek.
        //eğer realstartdate ve veya realenddate dolu ise o shift in gerçek saatleri real ler hesaplanarak fiyatlandırma yapılacak eğer gelmedi issimli tablo shiftte seçili ise hesaptan çıkarılacak.
        //Mapping
        public string? ExcuseDescription { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int WorkTypeId { get; set; }
        public WorkType workType { get; set; }
        public int ShiftStateId { get; set; }
        public ShiftState shiftState { get; set; }

    }
}
