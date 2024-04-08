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
    public class RoomTypeConfiguration : IEntityTypeConfiguration<RoomType>
    {
        public void Configure(EntityTypeBuilder<RoomType> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(256);

            builder.HasMany(rt => rt.Rooms).WithOne(r => r.roomType).HasForeignKey(r => r.RoomTypeId).IsRequired();
            builder.HasData(AddRoomTypeDefault());
        }
        private List<RoomType> AddRoomTypeDefault()
        {
            List<RoomType> roomType = new List<RoomType>
            {
                new RoomType{Id=1, Name="Tek Kişilik Oda" ,Description="Tek kişilik yataklı odalar. Her katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır."},
                new RoomType{Id=2,Name="İki Kişilik Oda",Description="İki kişilik yataklı odalar. Her katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır."},
                new RoomType{Id=3,Name="Üç Kişilik Oda",Description="Üç kişilik yataklı odalar. Yalnızca birinci katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır."},
                new RoomType{Id=4,Name="Dört Kişilik Oda",Description="Dört kişilik yataklı odalar. Yalnızca dördüncü katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır."},
                new RoomType{Id=5,Name="Kral Dairesi",Description="Özel bir konaklama deneyimi sunan lüks daire. Yalnızca dördüncü katta bulunabilir. Oda özellikleri: Kahvaltı, öğle yemeği ve akşam yemeği dahil değildir. Balkon bulunmaktadır. Minibar, klima, TV, saç kurutma makinesi ve kablosuz internet standarttır."}
            };
            return roomType;
        }
    }
}
