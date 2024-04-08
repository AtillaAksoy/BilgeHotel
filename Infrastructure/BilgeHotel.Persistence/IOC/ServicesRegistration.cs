
using BilgeHotel.Application.Repositories.CustomerRepositories;
using BilgeHotel.Application.Repositories.EmployeePriceRepositories;
using BilgeHotel.Application.Repositories.ImageHelpers;
using BilgeHotel.Application.Repositories.ImageRepositories;
using BilgeHotel.Application.Repositories.MailService;
using BilgeHotel.Application.Repositories.PriceTypeRepositories;
using BilgeHotel.Application.Repositories.ReservationRepositories;
using BilgeHotel.Application.Repositories.ReservationStateRepositories;
using BilgeHotel.Application.Repositories.ReservationTypeRepositories;
using BilgeHotel.Application.Repositories.RoomRepositories;
using BilgeHotel.Application.Repositories.RoomStateRepositories;
using BilgeHotel.Application.Repositories.RoomTypeRepositories;
using BilgeHotel.Application.Repositories.ShiftRepositories;
using BilgeHotel.Application.Repositories.ShiftStateRepositories;
using BilgeHotel.Application.Repositories.Token;
using BilgeHotel.Application.Repositories.WorkTypeRepositories;
using BilgeHotel.Domain.Entities.Identity;
using BilgeHotel.Persistence.Data;
using BilgeHotel.Persistence.Repositories.CustomerConcretes;
using BilgeHotel.Persistence.Repositories.EmployeePriceConcretes;
using BilgeHotel.Persistence.Repositories.ImageConcretes;
using BilgeHotel.Persistence.Repositories.ImageHelpers;
using BilgeHotel.Persistence.Repositories.MailService;
using BilgeHotel.Persistence.Repositories.PriceTypeConcretes;
using BilgeHotel.Persistence.Repositories.ReservationConcretes;
using BilgeHotel.Persistence.Repositories.ReservationStateConcretes;
using BilgeHotel.Persistence.Repositories.ReservationTypeConcretes;
using BilgeHotel.Persistence.Repositories.RoomConcretes;
using BilgeHotel.Persistence.Repositories.RoomStateConcretes;
using BilgeHotel.Persistence.Repositories.RoomTypeConcretes;
using BilgeHotel.Persistence.Repositories.ShiftConcretes;
using BilgeHotel.Persistence.Repositories.ShiftStateConcretes;
using BilgeHotel.Persistence.Repositories.Token;
using BilgeHotel.Persistence.Repositories.WorkTypeConcretes;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.IOC
{
    public static class ServicesRegistration
    {
        //public static void AddPersistenceServices(this IServiceCollection services)
        //{ 
        //    services.AddSingleton<ICustomerRepository,CustomerService>();
        //}
        public static IServiceCollection RegisterService(this IServiceCollection services, IConfiguration configuration)
        {
           // ServiceProvider provider = services.BuildServiceProvider();
            //var configuration = provider.GetService<IConfiguration>();

            services.AddDbContext<BilgeHotelContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")),ServiceLifetime.Singleton);
            //customer
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            //EmployeePrice
            services.AddScoped<IEmployeePriceReadRepository, EmployeePricerReadRepository>();
            services.AddScoped<IEmployeePriceWriteRepository, EmployePriceWriteRepository>();
            //Image
            services.AddScoped<IImageReadRepository, ImageReadRepository>();
            services.AddScoped<IImageWriteRepository, ImageWriteRepository>();
            //PriceType
            services.AddScoped<IPriceTypeReadRepositories, PriceTypeReadRepository>();
            services.AddScoped<IPriceTypeWriteRepositories, PriceTypeWriteRepository>();
            //Reservation
            services.AddScoped<IReservationReadRepository, ReservationReadRepository>();
            services.AddScoped<IReservationWriteRepository, ReservationWriteRepository>();
            //ReservationState
            services.AddScoped<IReservationStateReadRepository, ReservationStateReadRepository>();
            services.AddScoped<IReservationStateWriteRepository, ReservationStateWriteRepository>();
            //ReservationType
            services.AddScoped<IReservationTypeReadRepository, ReservationTypeReadRepository>();
            services.AddScoped<IReservationTypeWriteRepository, ReservationTypeWriteRepository>();
            //Room
            services.AddScoped<IRoomReadRepository, RoomReadRepository>();
            services.AddScoped<IRoomWriteRepository, RoomWriteRepository>();
            //RoomState
            services.AddScoped<IRoomStateReadRepository, RoomStateReadRepository>();
            services.AddScoped<IRoomStateWriteRepository, RoomStateWriteRepository>();
            //RoomType
            services.AddScoped<IRoomTypeReadRepository, RoomTypeReadRepository>();
            services.AddScoped<IRoomTypeWriteRepository, RoomTypeWriteRepository>();
            //Shift
            services.AddScoped<IShiftReadRepository, ShiftReadRepository>();
            services.AddScoped<IShiftWriteRepository, ShiftWriteRepository>();
            //ShiftState
            services.AddScoped<IShiftStateReadRepository, ShiftStateReadRepository>();
            services.AddScoped<IShiftStateWriteRepository, ShiftStateWriteRepository>();
            //WorkType
            services.AddScoped<IWorkTypeReadRepository, WorkTypeReadRepository>();
            services.AddScoped<IWorkTypeWriteRepository, WorkTypeWriteRepository>();

            services.AddScoped<ITokenHandler, TokenHandler>();

            services.AddScoped<IMailService , MailService>();

            services.AddScoped<IImageUploader , ImageUploader>();

            //Repository sınıflarının eklenmesi
            //services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            //services.AddScoped<ICustomerRepository, CustomerRepository>();

            services.AddIdentity<Employee, IdentityRole>()
      .AddEntityFrameworkStores<BilgeHotelContext>()
      .AddDefaultTokenProviders();


            return services;
        }
    }
}
