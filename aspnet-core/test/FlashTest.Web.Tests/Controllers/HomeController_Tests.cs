using System.Threading.Tasks;
using FlashTest.Models.TokenAuth;
using FlashTest.Web.Controllers;
using Shouldly;
using Xunit;

namespace FlashTest.Web.Tests.Controllers
{
    public class HomeController_Tests: FlashTestWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}