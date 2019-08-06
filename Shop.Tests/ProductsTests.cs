using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Shop.Application.Orders;
using Shop.Application.Products;
using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Threading.Tasks;
using Shop.Application.Orders;
using static Shop.Application.Products.GetProduct;

namespace Shop.Tests
{
    [TestFixture]
    public class ProductsTests
    {

        [Test]
        public async Task ReturnProduct()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("Test")
                .Options;

            using ( var context = new ApplicationDbContext(options))
            {

                context.Products.Add(new Product
                {
                    Name = "Test"
                });

                await context.SaveChangesAsync();

                var result = await new GetProduct(context).Do("Test");

                Assert.That(result.Name, Is.EqualTo("Test"));

            }
        }
    }
}
