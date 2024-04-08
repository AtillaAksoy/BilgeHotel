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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            //builder.ToTable("Employees");

            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
            builder.Property(e => e.UserName).HasMaxLength(50);
            builder.Property(e => e.IdentificationNumber).HasMaxLength(20);
            builder.Property(e => e.PhoneNumber).HasMaxLength(20);

         

            builder.HasMany(e => e.Reservations)
                   .WithOne(r => r.employee)
                   .HasForeignKey(r => r.EmployeId).IsRequired();

            builder.HasMany(e => e.EmployeePrices)
                   .WithOne(ep => ep.Employee)
                   .HasForeignKey(ep => ep.EmployeeId).IsRequired();

            //builder.HasMany(e => e.Roles)
            //       .WithOne(r => r.Employee)
            //       .HasForeignKey(r => r.EmployeId).IsRequired();

            builder.HasMany(e => e.Shifts)
                  .WithOne(r => r.Employee)
                  .HasForeignKey(r => r.EmployeeId).IsRequired();
        }
    }
}
