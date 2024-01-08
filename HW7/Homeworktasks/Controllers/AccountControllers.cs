using MyHTTPServer_1.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworktasks.Configuration;
using Homeworktasks.Services;
using Homeworktasks.Handlers;
using System.Runtime.InteropServices;

namespace Homeworktasks.Controllers
{
    [Controller("Account")]
    public class AccountControllers
    {
        [Post("SendToEmail")]
        public static void SendToEmail(string city,
            string address,
            string profession,
            string name,
            string lastname,
            string birthday,
            string phone,
            string social = " = ")
        {
            var config = AppSettingsLoader.Instance().Configuration;

            new EmailSenderService(config.MailSender, config.PasswordSender, config.ToEmail, config.SmtpServerHost, config.SmtpServerPort).SendEmailAsync(city, address, profession, name, lastname, birthday, phone, social);
            Console.WriteLine("Email was sent successfully!");
        }
    }
}