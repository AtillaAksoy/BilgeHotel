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
    public class WorkTypeWriteRepository : WriteRepository<WorkType>, IWorkTypeWriteRepository
    {
        public WorkTypeWriteRepository(BilgeHotelContext context) : base(context)
        {
        }
    }
}
