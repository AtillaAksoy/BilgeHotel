using BilgeHotel.Application.Repositories.ImageRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.ImageConcretes
{
    public class ImageReadRepository : ReadRepository<Image>, IImageReadRepository
    {
        public ImageReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
