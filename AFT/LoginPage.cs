using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AFT
{
    public class LoginPage
    {
        private readonly ChromeDriver driver;

        public LoginPage(ChromeDriver driver)
        {
            this.driver = driver;
        }

        public LoginPage Navigate()
        {
            driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");
            return this;
        }

        public LoginPage Submit()
        {
            driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();
            return this;
        }

        public IWebElement EmailErrorMessage()
        {
            return driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
        }

        public IWebElement EmailInput()
        {
            return driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/input");
        }
    }
}