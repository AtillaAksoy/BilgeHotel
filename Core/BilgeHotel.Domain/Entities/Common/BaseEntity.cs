using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BilgeHotel.Domain.Entities.Common
{
    public class BaseEntity
    {
        public BaseEntity()
        {
                CreatedDate = DateTime.Now;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        
        public bool IsPassive { get; set; }
        public bool IsDeleted { get; set; }
        //enum tipinde bir durum?

        public DateTime? UpdatedDate { get; set; }
        //created by ıd / updated by ıd / updatedate! eklenecek ve işlemleri yapılacak user işlemlerinden sonra.
        //base property'e durum diye enum bir tip belirleyip insert update delete bir nesne güncellendiğinde durumu güncellendiye cevirip aynı nesneden yeni bir tane daha oluşturmak mı daha mantıklı yoksa her log için ayrı bir tablo mu ? (bir oda güncellendi her güncellemede kim tarafından ne güncellendi)
    }
}
