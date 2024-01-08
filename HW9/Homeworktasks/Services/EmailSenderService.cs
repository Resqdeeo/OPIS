using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Homeworktasks.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        public string MailSender { get; private set; }
        public string PasswordSender { get; private set; }
        public string ToEmail { get; private set; }
        public string SmtpServerHost { get; private set; }
        public ushort SmtpServerPort { get; private set; }

        public EmailSenderService(string mailSender,
            string passwordSender,
            string toEmail,
            string smtpServerHost,
            ushort smtpServerPort)
        {
            MailSender = mailSender;
            PasswordSender = passwordSender;
            ToEmail = toEmail;
            SmtpServerHost = smtpServerHost;
            SmtpServerPort = smtpServerPort;
        }

        public async Task SendEmailAsync(string email, string password)
        {
            var from = new MailAddress(MailSender, "HttpServer");
            var to = new MailAddress(ToEmail);
            var m = new MailMessage(from, to);
            m.Subject = "Тест";
            m.Body = $"Email: {email.Split("=")[1]}\n" +
                     $"Password: {password.Split("=")[1]}\n";

            m.Attachments.Add(new Attachment("../../../../MyHTTPServer.rar"));
            var smtp = new SmtpClient(SmtpServerHost);
            smtp.Credentials = new NetworkCredential(MailSender, PasswordSender);
            smtp.EnableSsl = true;
            Console.WriteLine(MailSender + " " + PasswordSender);
            await smtp.SendMailAsync(m);
            Console.WriteLine("Письмо отправлено");
        }
    }
}