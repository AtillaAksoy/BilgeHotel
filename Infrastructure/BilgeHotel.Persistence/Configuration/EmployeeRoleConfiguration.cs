using BilgeHotel.Domain.Entities;
using BilgeHotel.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Configuration
{
    public class EmployeeRoleConfiguration:IEntityTypeConfiguration<EmployeeRole>
    {
        public void Configure(EntityTypeBuilder<EmployeeRole> builder)
        {

            //builder.ToTable("EmployeeRoles");

            //builder.Property(er => er.EmployeRoleName).HasMaxLength(50);
            //builder.Property(er => er.EmployeRoleDescription).HasMaxLength(100).IsRequired();


            //builder.HasOne(er => er.Employee)
            //       .WithMany(e => e.Roles)
            //       .HasForeignKey(er => er.EmployeId)
            //       .IsRequired(false);
            builder.HasData(AddEmployeRoleDefault());
        }
        private List<EmployeeRole> AddEmployeRoleDefault()
        {
            List<EmployeeRole> EmployeRole = new List<EmployeeRole>
            {
                new EmployeeRole{Id="31f0d778-5841-4d1e-ae3a-9ef45408df63",Name="Resepsiyon görevlisi" },
                new EmployeeRole{Id="cc9f54ef-46ea-42e0-ad1e-981794f28dd2",Name="Temizlik görevlisi" },
                new EmployeeRole{Id="ce293218-7d18-46dc-b65c-360836e78d5b",Name="Aşçı" },
                new EmployeeRole{Id="e37868b4-7c7d-411d-8876-0c918e1551a9",Name="Garson" },
                new EmployeeRole{Id="0e99a3ea-8766-41fa-81ce-18404d27ab09",Name="Elektrikçi" },
                new EmployeeRole{Id="9a8aaae6-e99f-4d37-aa2b-661b7e55d509",Name="Bilgi işlem sorumlusu" },
                new EmployeeRole{Id="80d0101f-5679-4709-85b4-58ed47976100",Name="Yönetim" },
                new EmployeeRole{Id="0421cd79-aded-4ed9-83cb-ff2a4f600bc7",Name="Admin" },
            };
            return EmployeRole;
        }
    }
}
