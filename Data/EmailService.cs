using BlazorServerAppDB.Data.BlazorServerApp;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;

namespace BlazorServerApp.Data
{
    public class EmailService
    {
        public IConfiguration Configuration { get; }
        public EmailService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public async Task SendEmailAsync(string emailTo, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            IConfigurationSection smtpSection =
                Configuration.GetSection("Smtp");
            
            emailMessage.From.Add(new MailboxAddress("BioHacker", smtpSection["Email"]));
            emailMessage.To.Add(new MailboxAddress("Пользователь", emailTo));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(smtpSection["SmtpProtocol"], 25, false);
                await client.AuthenticateAsync(smtpSection["Email"], smtpSection["Password"]);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}