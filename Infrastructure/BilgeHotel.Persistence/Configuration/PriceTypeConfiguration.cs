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
    public class PriceTypeConfiguration : IEntityTypeConfiguration<PriceType>
    {
        public void Configure(EntityTypeBuilder<PriceType> builder)
        {
            builder.Property(pt=>pt.Name).HasMaxLength(50);
            
            builder.HasMany(pt=>pt.employeePrices).WithOne(ep=>ep.PriceType).HasForeignKey(ep=>ep.PriceTypeId).IsRequired();
            builder.HasData(AddPriceTypeDefault());
        }
        private List<PriceType> AddPriceTypeDefault()
        {
            List<PriceType> priceTypes = new List<PriceType>
            {
                new PriceType{Id=1,Name="Saatlik"},
                new PriceType{Id=2,Name="Günlük"},
                new PriceType{Id=3,Name="Aylık"}
            };
            return priceTypes;
        }
    }
}
