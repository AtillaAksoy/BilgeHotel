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
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {

            builder.Ignore(x => x.CreatedDate);
            builder.Property(x => x.RealStartDate).IsRequired();
            builder.Property(x => x.RealEndDate).IsRequired();
            builder.Property(x=>x.ExcuseDescription).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.Employee).WithMany(r => r.Shifts).HasForeignKey(rt => rt.EmployeeId);
            builder.HasOne(x => x.workType).WithMany(r => r.Shifts).HasForeignKey(rt => rt.WorkTypeId);
            builder.HasOne(x => x.shiftState).WithMany(r => r.Shifts).HasForeignKey(rt => rt.ShiftStateId);
        }
    }
}
