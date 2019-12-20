using BlazorServerAppDB.Data.BlazorServerApp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;

namespace BlazorServerApp.Data
{
    public class EmailService
    {
        public async Task SendEmailAsync(string emailFrom, string password, string emailTo, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("BioHacker", emailFrom));
            emailMessage.To.Add(new MailboxAddress("Пользователь", emailTo));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.mail.ru", 25, false);
                await client.AuthenticateAsync(emailFrom, password);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}