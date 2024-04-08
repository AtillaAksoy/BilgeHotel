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
    public class RoomStateConfiguration : IEntityTypeConfiguration<RoomState>
    {
        public void Configure(EntityTypeBuilder<RoomState> builder)
        {
            builder.Property(x=>x.State).HasMaxLength(50);
            builder.Property(x=>x.Note).HasMaxLength(150).IsRequired();

            builder.HasMany(rt => rt.Rooms).WithOne(r => r.roomState).HasForeignKey(r => r.RoomStateId).IsRequired();
            builder.HasData(AddRoomStateDefault());
        }
        private List<RoomState> AddRoomStateDefault()
        {
            List<RoomState> roomState = new List<RoomState>
            {
                new RoomState{Id=1,State="Dolu",Note="Kiralama yapılamaz"},
                new RoomState{Id=2,State="Boş",Note="Temizlendi eksikleri giderildi yeni müşterisini bekliyor"},
                new RoomState{Id=3,State="Temizlenecek",Note="Oda boşaldı temizlik personeli bekliyor"},
                new RoomState{Id=4,State="Bakım",Note="Oda'da arıza mevcut teknisyen bekliyor"}
            };
            return roomState;
        }
    }
}
