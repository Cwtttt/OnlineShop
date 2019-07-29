using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Cart
{
    public class DeleteFromCart
    {
        private ApplicationDbContext _ctx;
        private ISession _session;

        public DeleteFromCart( ISession session, ApplicationDbContext ctx)
        {
            _session = session;
            _ctx = ctx;
        }

        public class Request
        {
            public int StockId { get; set; }
            public int Qty { get; set; }
        }

        public async Task<bool> Do(Request request)
        {
            var stocksOnHold = _ctx.StocksOnHold.Where(x => x.SessionId == _session.Id).ToList();
            var stockToExtension = _ctx.Stock.Where(x => x.Id == request.StockId).FirstOrDefault();

            stockToExtension.Qty += request.Qty;

            foreach (var stock in stocksOnHold)
            {
                stock.ExpiryDate = DateTime.Now.AddMinutes(20);
            }

            var stockOnHold = _ctx.StocksOnHold.Where(x => x.StockId == request.StockId).FirstOrDefault();

            _ctx.StocksOnHold.Remove(stockOnHold);

            await _ctx.SaveChangesAsync();

            var cartList = new List<CartProduct>();
            var stringObject = _session.GetString("cart");

            if (!string.IsNullOrEmpty(stringObject))
            {
                cartList = JsonConvert.DeserializeObject<List<CartProduct>>(stringObject);
            }

            var cartProductToRemove = cartList.Where(x => x.StockId == request.StockId).FirstOrDefault();

            cartList.Remove(cartProductToRemove);


            stringObject = JsonConvert.SerializeObject(cartList);

            _session.SetString("cart", stringObject);

            return true;
        }
    }
}
