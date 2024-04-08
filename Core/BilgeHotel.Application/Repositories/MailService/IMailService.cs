using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Application.Repositories.MailService
{
    public interface IMailService
    {
        Task SendMessageAsync(string to, string subject, string body,bool IsBodyHtml = true);
    }
}
