//namespace SorApp.Infrastructure.Services;

//using System.Net;
//using System.Net.Mail;
//using Microsoft.Extensions.Configuration;

//public class EmailSender : IEmailSender<User>
//{
//    private readonly IConfiguration _configuration;

//    public EmailSender(IConfiguration configuration)
//    {
//        _configuration = configuration;
//    }

//    public async Task SendEmailAsync(string to, string subject, string body)
//    {
//        var smtpClient = new SmtpClient
//        {
//            Host = _configuration["Email:Smtp:Host"],
//            Port = int.Parse(_configuration["Email:Smtp:Port"]!),
//            EnableSsl = true,
//            Credentials = new NetworkCredential(
//                _configuration["Email:Smtp:Username"],
//                _configuration["Email:Smtp:Password"])
//        };

//        var mailMessage = new MailMessage
//        {
//            From = new MailAddress(_configuration["Email:From"]),
//            Subject = subject,
//            Body = body,
//            IsBodyHtml = true
//        };

//        mailMessage.To.Add(to);

//        await smtpClient.SendMailAsync(mailMessage);
//    }
//}

