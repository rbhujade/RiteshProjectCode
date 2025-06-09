using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using WebAPI.Controllers;
using WebAPI.Model;
using WebAPI.Models;
using WebAPI.Services;

namespace ProductTest_xUnit
{
    public class ProductText_xUnit
    {
        [Fact]
        public void Test_ProductControllerMethod()
        {
            //Arrage
            var mockService = new Mock<IProductService>();
            mockService.Setup(s => s.GetAllProducts())
                .Returns(new List<Product>
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Mobile",
                        Price = 100000
                    }
                });
            var controller = new ProductController(mockService.Object);

            //Act
            var result = controller.GetAllProduct();

            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var product = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);
            Assert.Single(product);
        }

        [Fact]
        public void Test_Repo()
        {
            // Arrange
            //var options = new DbContextOptionsBuilder<ProductDbContext>()
              //            .UseInMemoryDatabase("ProductTestDb")
                //          .Options;
        }
    }
}