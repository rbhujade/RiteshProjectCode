using Microsoft.EntityFrameworkCore;
using WebAPI.Models;
using System.Linq;

namespace ProductTest
{
    [TestClass]
    public class ProductTest_MSTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ProductDbContext>()
                          .UseInMemoryDatabase("ProductTestDb")
                          .Options;
        }
    }
}