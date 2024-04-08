using BilgeHotel.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Configuration
{
    public class ShiftStateConfiguraiton : IEntityTypeConfiguration<ShiftState>
    {
        public void Configure(EntityTypeBuilder<ShiftState> builder)
        {
            builder.Ignore(x => x.CreatedDate);
            builder.Property(x=>x.Name).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(250).IsRequired();
            
            builder.HasMany(rt => rt.Shifts).WithOne(r => r.shiftState).HasForeignKey(r => r.ShiftStateId).IsRequired();
            builder.HasData(AddShiftStateDefault());
        }
        private List<ShiftState> AddShiftStateDefault()
        {
            List<ShiftState> shiftState = new List<ShiftState>
            {
                new ShiftState{Id=1,Name="Planlanan",Description="Planlama gerçekleşti uyulması bekleniyor."},
                new ShiftState{Id=2,Name="Tamamlandı",Description="Uyum sağlandı tam zamanlı çalışıldı."},
                new ShiftState{Id=3,Name="Geç Geldi",Description="Çalışan geç geldiyse shifti güncelleyerek gerçek giriş saatini doldurunuz ve açıklamasını yazınız."},
                new ShiftState{Id=4,Name="Erken Çıktı",Description="Çalışan erken çıktı ise shifti güncelleyerek gerçek çıkış saatini doldurunuz ve açıklamasını yazınız."},
                new ShiftState{Id=5,Name="Geç Geldi Ve Erken Çıktı",Description="Çalışan geç gelip erken çıktı ise shifti güncelleyerek gerçek giriş ve çıkış saatlerini doldurunuz ayrıca açıklamasını yazınız."},
                new ShiftState{Id=6,Name="Gelmedi",Description="Çalışan haberli veya habersiz gelmedi ise shifti güncelleyerek çalışma tipini 'Ücretli Mazeret İzni' veya 'Ücretsiz Mazeret İzni' olarak güncelleyiniz."}
            };
            return shiftState;
        }
    }
}
