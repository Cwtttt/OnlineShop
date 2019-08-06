using System;
using System.Collections.Generic;
using System.Text;
using MailKit.Net.Smtp;
using MimeKit;
using Shop.Domain.Models;
using System.Text;

namespace Shop.Application.Mails
{
    public class SendOrderInfo
    {
        public void Do(Request request)
        {
            var message = new MimeMessage();

            message.From.Add(new MailboxAddress("Online Shop", "xxxxxxxxxxxx"));

            message.To.Add(new MailboxAddress(request.FirstName, request.Email));

            message.Subject = "Twoje zamówienie";


            message.Body = new TextPart("plain")
            {
                Text = BuildBody(request)
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("xxxxxx", "xxxxxxxxxx");

                client.Send(message);

                client.Disconnect(true);
            }

        }

        public string BuildBody(Request request)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append("Twoje zamówione produkty: " + "\n");

            int i = 0;

            foreach (var stock in request.Stocks)
            {
                i++;
                sb.AppendFormat("<br/>{0}. {1} Rozmiar: {2}", i, stock.Product.Name, stock.Description);
                sb.Append("\n");
            }

            sb.Append("Twoje dane do wysylki: " + "\n");
            sb.AppendFormat("Imie: {0}", request.FirstName);
            sb.Append("\n");
            sb.AppendFormat("Nazwisko: {0}", request.LastName);
            sb.Append("\n");
            sb.AppendFormat("Numer telefonu: {0}", request.PhoneNumber);
            sb.Append("\n");
            sb.AppendFormat("Adres: {0}", request.Address1);
            sb.Append("\n");
            sb.AppendFormat("Miasto: {0}", request.City);
            sb.Append("\n");
            sb.AppendFormat("Kod pocztowy: {0}", request.PostCode);
            sb.Append("\n");
            return sb.ToString();
        }
        public class Request
        {


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            public string Address1 { get; set; }
            public string Address2 { get; set; }
            public string City { get; set; }
            public string PostCode { get; set; }

            public List<Stock> Stocks { get; set; }
        }

        public class Stock
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }

            public int ProductId { get; set; }
            public Product Product { get; set; }
        }
    }
}
