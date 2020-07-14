using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace OPAC.Controllers
{
    public class GeneralController
    {
        [NonAction]
        public void SendEmailResetPassword(string email, string newPassword)
        {
            try
            {
                var fromEmail = new MailAddress("damar.sesarrahman@gmail.com", "OPAC Mail System");
                var toEmail = new MailAddress(email);
                var fromEmailPassword = "for 147862"; // Replace with actual password
                string subject = "OPAC - Reset Password";

                string body = "<html><body>" +
                    "<p>Selamat, anda telah berhasil mereset password. </p>" +
                    "Password baru anda : " + newPassword + "<br/><br/>" +
                    "<p><i>Email ini dikirim secara otomatis oleh sistem, diharapkan tidak membalas email ini.</i></p>" +
                    "</body></html>";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
                };

                MailMessage message = new MailMessage();  
                message.From = fromEmail;  
                message.To.Add(toEmail);  
                message.Subject = subject;  
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = body;

                smtp.Send(message);   
            }
            catch (Exception ex)
            {
                throw ex;                
            }
        }
    }
}