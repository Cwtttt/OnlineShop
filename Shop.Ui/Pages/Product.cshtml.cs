using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Products;
using Shop.Database;

namespace Shop.Ui.Pages
{
    public class ProductModel : PageModel
    {

        private ApplicationDbContext _ctx;

        public GetProduct.ProductViewModel Product { get; set; }
        public ProductModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult OnGet(string name)
        {
            Product = new GetProduct(_ctx).Do(name.Replace(" ", "-"));
            if (Product == null)
                return RedirectToPage("Index");
            else
                return Page();
        }
    }
}