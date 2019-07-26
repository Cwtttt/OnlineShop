using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.Application.Stocks
{
    public class GetStock
    {
        private ApplicationDbContext _ctx;

        public GetStock(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public StockViewModel Do(int id)
        {
            var stock = _ctx.Stock.FirstOrDefault(x => x.Id == id);

            StockViewModel stockViewModel = new StockViewModel
            {
                Id = stock.Id,
                ProductId = stock.ProductId,
                Description = stock.Description,
                Qty = stock.Qty
            };

            return stockViewModel;
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public int ProductId { get; set; }
            public string Description { get; set; }
            public int Qty { get; set; }
        }
    }
}
