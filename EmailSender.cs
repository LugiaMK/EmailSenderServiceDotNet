﻿using System.Net;
using System.Net.Mail;

namespace EmailService
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "qwerty@outlook.com";
            var pw = "Test12345";

            var client = new SmtpClient("smtp-mail.outlook.com", 587)

            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)

            };

            return client.SendMailAsync(
                new MailMessage(from: mail,
                                to: email,
                                subject,
                                message));

            
            //throw new NotImplementedException();
        }
    }
}
