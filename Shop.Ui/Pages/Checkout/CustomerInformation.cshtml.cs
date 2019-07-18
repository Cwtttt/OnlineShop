using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Database;
using Shop.Application.Cart;
using Microsoft.AspNetCore.Hosting;

namespace Shop.Ui.Pages.Checkout
{
    public class CustomerInformationModel : PageModel
    {
        private IHostingEnvironment _env;

        public CustomerInformationModel(IHostingEnvironment env)
        {
            _env = env;
        }

        [BindProperty]
        public AddCustomerInformation.Request Customerinformation { get; set; }
        public IActionResult OnGet()
        {
            var information = new GetCustomerInformation(HttpContext.Session).Do();

            if(information == null)
            {
                if (_env.IsDevelopment())
                {
                    Customerinformation = new AddCustomerInformation.Request
                    {
                        Firstname = "A",
                        LastName = "A",
                        Email = "A@A.com",
                        PhoneNumber = "111111111",
                        Address1 = "A",
                        Address2 = "A",
                        City = "A",
                        PostCode = "A"
                    };
                }
                return Page();
            }
            else
            {
                return RedirectToPage("/Checkout/Payment");
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            new AddCustomerInformation(HttpContext.Session).Do(Customerinformation);

            return RedirectToPage("/Checkout/Payment");
        }
    }
}