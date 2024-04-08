using BilgeHotel.Application.Repositories;
using BilgeHotel.Application.Repositories.WorkTypeRepositories;
using BilgeHotel.Domain.Entities;
using BilgeHotel.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.WorkTypeConcretes
{
    public class WorkTypeReadRepository : ReadRepository<WorkType>, IWorkTypeReadRepository
    {
        public WorkTypeReadRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
