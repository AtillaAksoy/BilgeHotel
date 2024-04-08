using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.Token
{
    public interface ITokenHandler
    {
       Dtos.Token CreateAccessToken(int day);
    }
}
