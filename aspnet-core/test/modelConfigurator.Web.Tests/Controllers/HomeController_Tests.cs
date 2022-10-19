using System.Threading.Tasks;
using modelConfigurator.Models.TokenAuth;
using modelConfigurator.Web.Controllers;
using Shouldly;
using Xunit;

namespace modelConfigurator.Web.Tests.Controllers
{
    public class HomeController_Tests: modelConfiguratorWebTestBase
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