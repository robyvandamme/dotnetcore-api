using System;
using System.Threading.Tasks;
using Core;
using Core.Data;
using Core.Entities;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RestApi.Controllers.Public;
using RestApi.Services;
using Xunit;

namespace Specs.Products
{
    [Trait("Get Product By Id", "")]
    public class GetById
    {
        [Fact(DisplayName = "Send Single Product response")]
        public async Task Send_Product_Response()
        {
            var dataMock = new Mock<IProductRepository>();
            var urlServiceMock = new Mock<IUrlService>();

            dataMock.Setup(data => data.GetById(It.IsAny<Guid>())).ReturnsAsync(new Product() { Name = "Product One" });
            var controller = new ProductsController(dataMock.Object, urlServiceMock.Object);

            var result = await controller.GetById(Guid.NewGuid()) as OkObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);

            var products = result.Value as Product;
            products.Should().NotBeNull();
        }
    }
}
