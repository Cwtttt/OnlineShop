using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Database;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.Ui.Pages
{
    public class CartModel : PageModel
    {
        private ApplicationDbContext _ctx;

        public CartModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<GetCart.Response> Cart { get; set; }
        [BindProperty]
        public DeleteFromCart.Request SelectedProduct { get; set; }
        public IActionResult OnGet()
        {
            Cart = new GetCart(HttpContext.Session, _ctx).Do();

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            var stockDeleted = await new DeleteFromCart(HttpContext.Session, _ctx).Do(SelectedProduct);

            if (stockDeleted)
                return RedirectToPage("Cart");
            else
                return Page();
        }
    }
}