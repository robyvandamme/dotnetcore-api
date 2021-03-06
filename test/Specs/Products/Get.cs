using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Core.Data;
using Core.Entities;
using Core.Parameters;
using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using RestApi.Controllers.Public;
using RestApi.Services;
using Xunit;

namespace Specs.Products
{
    [Trait("Get Products", "")]
    public class Get
    {
        [Fact(DisplayName = "Send Products response")]
        public async Task Send_Products_Response()
        {
            var dataMock = new Mock<IProductRepository>();
            var urlServiceMock = new Mock<IUrlService>();
            var httpContextMock = new Mock<HttpContext>();

            var parameters = new ProductQueryParameters();
            var pagedList = new PagedList<Product>(new List<Product>() { new Product() { Name = "Product One", Color = "Black" } }, 1, parameters);

            dataMock.Setup(data => data.Get(parameters)).ReturnsAsync(pagedList);
            httpContextMock.Setup(context => context.Response.Headers).Returns(new HeaderDictionary());

            var controller = new ProductsController(dataMock.Object, urlServiceMock.Object);
            controller.ControllerContext = new ControllerContext();
            controller.ControllerContext.HttpContext = httpContextMock.Object;

            var result = await controller.Get(parameters) as ObjectResult;

            result.Should().NotBeNull();
            result.StatusCode.Should().Be(200);

            var products = result.Value as IEnumerable<Product>;
            products.Should().NotBeNullOrEmpty();
        }
    }
}
