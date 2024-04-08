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
    public class ReservationStateConfiguration : IEntityTypeConfiguration<ReservationState>
    {
        public void Configure(EntityTypeBuilder<ReservationState> builder)
        {
            builder.Property(rs=>rs.StateName).HasMaxLength(50);
            builder.Property(rs=>rs.Description).HasMaxLength(150);

            builder.HasMany(e => e.Reservations)
                       .WithOne(r => r.reservationState)
                       .HasForeignKey(r => r.ReservationStateId).IsRequired();
            builder.HasData(AddReservationStateDefault());
        }
        private List<ReservationState> AddReservationStateDefault()
        {
            List<ReservationState> reservationState = new List<ReservationState>
            {
                new ReservationState{Id=1,StateName="Planlandı",Description="ödemesi alındı gerçekleştirilecek"},
                new ReservationState{Id=2,StateName="Tamamlandı",Description="Kiralama işlemi başarıyla gerçekleşti"},
                new ReservationState{Id=3,StateName="İptal-iadeli",Description="rezervasyonu güncelleyerek iade edilecek tutarı yazmayı ve iade sebebini açıklamayı unutmayınız"},
                new ReservationState{Id=4,StateName="İptal-iadesiz",Description="rezervasyonu güncelleyerek açıklamaya iade sebebini yazmayı unutmayınız"},
                new ReservationState{Id=5,StateName="Başladı ödeme alınmadı",Description="Ödeme almayı unutmayınız"},
                new ReservationState{Id=6,StateName="Başladı ödeme alındı",Description="durum tamamlandıya çevrilebilir"}
            };
            return reservationState;
        }
    }
}
