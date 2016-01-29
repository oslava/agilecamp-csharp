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
                NavigateToLoginPage(driver);

               //var loginErrorMessage1 = driver.FindElementsByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
               // Assert.AreEqual(0, loginErrorMessage1.Count);

                GetSubmitLoginButton(driver).Click();

                var loginErrorMessage = GetLoginErrorMewssage(driver);

                Assert.True(loginErrorMessage.Displayed);
            }
        }

        private static void NavigateToLoginPage(ChromeDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");
        }

        private static IWebElement GetLoginErrorMewssage(ChromeDriver driver)
        {
            return driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
        }

        private static IWebElement GetSubmitLoginButton(ChromeDriver driver)
        {
            return driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input");
        }

        [Test]
        public void IfEmailAddressIsNotValid_ShowValidationMessage()
        {
            using (var driver = new ChromeDriver())
            {
                NavigateToLoginPage(driver);

                var emailImput = GetLoginInputField(driver);
                emailImput.SendKeys("xxx");

                GetSubmitLoginButton(driver).Click();

                var loginErrorMessage = GetLoginErrorMewssage(driver);

                Assert.True(loginErrorMessage.Displayed);
            }
            //using (var driver = new ChromeDriver())
            //{
            //    driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");

            //    var loginErrorMessage1 = driver.FindElementsByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
            //    Assert.AreEqual(0, loginErrorMessage1.Count);


            //    //var emailImput = driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/input");
            //    //emailImput.SendKeys("xxx");

            //    //driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();

            //    var loginErrorMessage = driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");

            //    Assert.True(loginErrorMessage.Displayed);
            //}
        }

        private static IWebElement GetLoginInputField(ChromeDriver driver)
        {
            return driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/input");
        }
    }
}