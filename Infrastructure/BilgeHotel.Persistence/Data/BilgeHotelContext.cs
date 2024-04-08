using BilgeHotel.Domain.Entities;
using BilgeHotel.Domain.Entities.Identity;
using BilgeHotel.Persistence.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Data
{
    public class BilgeHotelContext : IdentityDbContext<Employee, EmployeeRole,string>
    {
        //public BilgeHotelContext()
        //{
                
        //}
        public BilgeHotelContext(DbContextOptions<BilgeHotelContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; } 
        public DbSet<EmployeeRole> EmployeRoles { get; set; }
        public DbSet<EmployeePrice> EmployeePrices { get; set; }
        public DbSet<PriceType> PriceTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ReservationState> ReservationsStates { get; set; }
        public DbSet<ReservationType> ReservationsTypes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomState> RoomsStates { get; set;}
        public DbSet<RoomType> RoomsTypes { get; set;}
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<ShiftState> ShiftStates { get; set; }
        public DbSet<WorkType> WorkTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }


        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Configurations
            builder.ApplyConfiguration(new EmployeeConfiguration());
            builder.ApplyConfiguration(new EmployeeRoleConfiguration());
            builder.ApplyConfiguration(new EmployeePriceConfiguration());
            builder.ApplyConfiguration(new PriceTypeConfiguration());
            builder.ApplyConfiguration(new ReservationConfiguration());
            builder.ApplyConfiguration(new ReservationStateConfiguration());
            builder.ApplyConfiguration(new ReservationTypeConfiguration());
            builder.ApplyConfiguration(new RoomConfiguration());
            builder.ApplyConfiguration(new RoomStateConfiguration());
            builder.ApplyConfiguration(new RoomTypeConfiguration());
            builder.ApplyConfiguration(new ShiftConfiguration());
            builder.ApplyConfiguration(new ShiftStateConfiguraiton());
            builder.ApplyConfiguration(new WorkTypeConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());

            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS;database=BilgeHotel;Trusted_Connection=True;TrustServerCertificate=True",b=>b.MigrationsAssembly("BilgeHotel.Persistence"));
            }
            //optionsBuilder..UseLazyLoadingProxies();  //Microsoft.EntityFrameworkCore.Proxies
            base.OnConfiguring(optionsBuilder);
        }

    }
}
