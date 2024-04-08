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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
           builder.Property(r=>r.price).HasColumnType("money");
            //builder.Property(r => r.ImagePath).HasMaxLength(255);


            builder.HasOne(rt => rt.roomType).WithMany(r => r.Rooms).HasForeignKey(rt => rt.RoomTypeId);
            builder.HasOne(rt => rt.roomState).WithMany(r => r.Rooms).HasForeignKey(rt => rt.RoomStateId);
            builder.HasMany(rt => rt.reservations).WithOne(r => r.room).HasForeignKey(r => r.RoomId).IsRequired();
            builder.HasMany(rt => rt.Images).WithOne(r => r.Room).HasForeignKey(r => r.RoomId).IsRequired();
        }
    }
}
