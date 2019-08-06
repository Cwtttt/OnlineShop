using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit;

namespace Shop.Ui.Controllers
{
    public class MailTestController : Controller
    {
        public IActionResult Send()
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Tester", "mdevmailkittester@gmail.com"));

            message.To.Add(new MailboxAddress("Artur", "wisniewski.artur96@gmail.com"));

            message.Subject = "test email :)))))))))";

            message.Body = new TextPart("plain")
            {
                Text = "Mailkit"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("mdevmailkittester@gmail.com", "mailkit!!");

                client.Send(message);

                client.Disconnect(true);
            }

            return RedirectToPage("/Send");
        }
    }
}