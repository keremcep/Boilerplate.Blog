using System.Threading.Tasks;
using boilerplate.Models.TokenAuth;
using boilerplate.Web.Controllers;
using Shouldly;
using Xunit;

namespace boilerplate.Web.Tests.Controllers
{
    public class HomeController_Tests: boilerplateWebTestBase
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