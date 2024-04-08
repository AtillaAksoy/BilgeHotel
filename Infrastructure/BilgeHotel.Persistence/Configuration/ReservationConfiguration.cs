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
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.Property(e => e.TotalPrice).HasColumnType("money");
            builder.Property(e => e.RealPrice).HasColumnType("money");

            builder.Property(rs => rs.RefuendedPrice).HasColumnType("money");

            builder.Property(rs => rs.CancelDescription).HasMaxLength(100);

            builder.HasOne(r => r.reservationType).WithMany(rt => rt.Reservations).HasForeignKey(r => r.ReservationTypeId);
            builder.HasOne(r => r.reservationState).WithMany(rs => rs.Reservations).HasForeignKey(r => r.ReservationStateId);
            builder.HasOne(r => r.customer).WithMany(c => c.Reservations).HasForeignKey(r => r.CustomerId);
            builder.HasOne(r => r.room).WithMany(r => r.reservations).HasForeignKey(r => r.RoomId);
            builder.HasOne(r => r.employee).WithMany(e => e.Reservations).HasForeignKey(r => r.EmployeId).IsRequired(false);
        }
    }
}
