using System.Net;
using System.Net.Mail;

namespace HCMISAPI.Emailing
{
    public class EmailModel
    {
        private string SenderEmail { get; set; }
        private string SenderHost { get; set; }
        private string SenderPassword { get; set; }
        private int SenderPort { get; set; }
        private bool EnableSSL { get; set; }

        public EmailModel()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                               .SetBasePath(Directory.GetCurrentDirectory())
                                               .AddJsonFile("appsettings.json")
                                               .Build();
            SenderEmail = configuration.GetSection("EmailCredentials")["SenderEmail"];
            SenderHost = configuration.GetSection("EmailCredentials")["SenderHost"];
            SenderPassword = configuration.GetSection("EmailCredentials")["SenderPassword"];
            SenderPort = Convert.ToInt32(configuration.GetSection("EmailCredentials")["SenderPort"]);
            EnableSSL = Convert.ToBoolean(configuration.GetSection("EmailCredentials")["EnableSsl"]);
        }
        public void SendAccountActivationEmail(string _message,string email)
        {
            using (var message = new MailMessage(SenderEmail, email))
            {
                message.Subject = "HCMIS Account Activation";
                message.Body = _message;
                message.IsBodyHtml = true;
                using (SmtpClient client = new SmtpClient
                {
                    EnableSsl = EnableSSL,
                    Host = SenderHost,//PAU Host
                    Port = SenderPort,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(SenderEmail, SenderPassword)
                })
                {
                    //client.EnableSsl = true;
                    client.Send(message);
                }
            }
        }
    }
}
