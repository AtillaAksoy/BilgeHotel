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
    public class EmployeePriceConfiguration : IEntityTypeConfiguration<EmployeePrice>
    {
        public void Configure(EntityTypeBuilder<EmployeePrice> builder)
        {
            builder.Property(e => e.Price).HasColumnType("money");

            builder.HasOne(ep => ep.Employee).WithMany(e => e.EmployeePrices).HasForeignKey(ep => ep.EmployeeId);
            builder.HasOne(ep => ep.PriceType).WithMany(e => e.employeePrices).HasForeignKey(ep => ep.PriceTypeId);
        
        }
    }
}
