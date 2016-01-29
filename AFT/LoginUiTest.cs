using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace AFT
{
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;

    // PageObjects pattern https://code.google.com/p/selenium/wiki/PageObjects

    public class LoginUiTest
    {
        [Test]
        public void IfEmailAddressIsMissing_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                var displayed = new LoginPage(driver)
                    .Navigate()
                    .Submit()
                    .EmailErrorMessage().Displayed;

                Assert.True(displayed);
            }
        }

        [Test]
        public void IfEmailAddressIsNotValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                var loginPage = new LoginPage(driver);
                loginPage.Navigate();

                var emailImput = loginPage.EmailInput();
                emailImput.SendKeys("xxx");

                loginPage
                    .Submit();

                var loginErrorMessage = loginPage.EmailErrorMessage();

                Assert.True(loginErrorMessage.Displayed);
            }
        }
    }
}