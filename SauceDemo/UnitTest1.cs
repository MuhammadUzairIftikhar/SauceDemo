using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SauceDemo
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            // Create a new instance of the Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            // Navigate to the URL
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            driver.Manage().Window.Maximize();

            // Finds and Enters the Username 
            IWebElement usernameField = driver.FindElement(By.Name("user-name"));
            usernameField.SendKeys("standard_user");

            // Finds and Enter the Password
            IWebElement passwordField = driver.FindElement(By.Id("password"));
            passwordField.SendKeys("secret_sauce");

            // Find the Login Button and Click it 
            IWebElement loginButton = driver.FindElement(By.Id("login-button"));
            loginButton.Click();



            
        }
    }
}