using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        UserService userService;
        [SetUp]
        public void SetUp()
        {
            userService = new UserService();
        }
        [Test]
        public void RegisterShouldThrowExceptionsIfInputIsIncorrect()
        {
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "Test",
                LastName = "Test",
                Password = "",
                Email = "Test@gmail.com"
            }));
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "",
                LastName = "Test",
                Password = "41241234",
                Email = "Test@gmail.com"
            }));
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "Test",
                LastName = "",
                Password = "123412341",
                Email = "Test@gmail.com"
            }));
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "Test",
                LastName = "Test",
                Password = "123412412",
                Email = ""
            }));
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "Test",
                LastName = "Test",
                Password = "123",
                Email = "Test@gmail.com"
            }));
            Assert.Throws<ArgumentNullException>(() => userService.Register(new UserRegistrationData()
            {
                FirstName = "Test",
                LastName = "Test",
                Password = "32412341242134",
                Email = "Test"
            }));
        }
    }
}