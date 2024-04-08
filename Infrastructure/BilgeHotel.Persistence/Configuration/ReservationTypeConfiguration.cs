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
    public class ReservationTypeConfiguration : IEntityTypeConfiguration<ReservationType>
    {
        public void Configure(EntityTypeBuilder<ReservationType> builder)
        {
            builder.Property(rs => rs.Name).HasMaxLength(50);
            builder.Property(rs => rs.Description).HasMaxLength(150);
            builder.HasMany(e => e.Reservations)
                       .WithOne(r => r.reservationType)
                       .HasForeignKey(r => r.ReservationTypeId).IsRequired();
            builder.HasData(AddReservationTypeDefault());
        }
        private List<ReservationType> AddReservationTypeDefault()
        {
            List<ReservationType> reservationType = new List<ReservationType>
            {
                new ReservationType{Id=1,Name="Tam pansiyon",Description="Konaklama ücretine kahvaltı, öğle yemeği ve akşam yemeği dahildir."},
                new ReservationType{Id=2,Name="Her şey dahil",Description="Konaklama ücretine yemeklerin yanı sıra içecekler ve bazı aktiviteler de dahildir."}
                
            };
            return reservationType;
        }
    }
}
