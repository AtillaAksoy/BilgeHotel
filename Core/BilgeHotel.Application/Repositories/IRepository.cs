using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories
{
    public interface IRepository<T> where T : class//generic bir yapıda olduğunu ve bir klass olduğunu söylüyorum
    {
        DbSet<T> Table { get; }//Concrete' de DI olarak yapılabilirdi.
    }
}
