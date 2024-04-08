using BilgeHotel.Application.Repositories.MailService;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BilgeHotel.Persistence.Repositories.MailService
{
    public class MailService : IMailService
    {
        private readonly IConfiguration _configuration;
        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendMessageAsync(string to, string subject, string body, bool IsBodyHtml = true)
        {
            MailMessage mail = new();
            mail.IsBodyHtml = IsBodyHtml;
            mail.To.Add(to);
            mail.Subject = subject;
            mail.Body = body;
            mail.From = new("Yzl3171@outlook.com" ,"bilge hotel proje");

            SmtpClient smtp = new();
            smtp.Credentials = new NetworkCredential("Yzl3171@outlook.com", "Kadikoy3171--");
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Host = "smtp-mail.outlook.com";
            await smtp.SendMailAsync(mail);
        }
    }
}
