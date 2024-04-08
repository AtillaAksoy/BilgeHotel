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
    public class WorkTypeConfiguration : IEntityTypeConfiguration<WorkType>
    {
        public void Configure(EntityTypeBuilder<WorkType> builder)
        {
            builder.Ignore(x => x.CreatedDate);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(250).IsRequired();
            builder.HasMany(rt => rt.Shifts).WithOne(r => r.workType).HasForeignKey(r => r.WorkTypeId).IsRequired();
            builder.HasData(AddWorkTypeDefault());
        }
        private List<WorkType> AddWorkTypeDefault()
        {
            List<WorkType> workType = new List<WorkType>
            {
                new WorkType{Id=1,Name="Normal Mesai Sabah ",Description="Sabah vardiyası: 08:00 - 16:00 1/3"},
                new WorkType{Id=2,Name="Normal Mesai Akşam ",Description="Akşam vardiyası: 16:00 - 00:00 1/3"},
                new WorkType{Id=3,Name="Normal Mesai Gece",Description="Gece vardiyası: 00:00 - 08:00 1/3"},
                new WorkType{Id=4,Name="Normal Mesai",Description="mesai saatleri 8:00 ile 18:00"},
                new WorkType{Id=5,Name="Ek Mesai",Description="Ücretli Ek Mesai"}
            };
            return workType;
        }
    }
}
