using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{
      public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.CssSelector("[for=Name] +input")).SendKeys("user");
            driver.FindElement(By.CssSelector("[for=Password] +input")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
        }

        [Test]
        public void LogoutTest()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            var TitleValue = driver.FindElement(By.CssSelector("h2")).Text;
            Assert.AreEqual("Login", TitleValue);
        }

        [Test]
        public void CheckProductTest()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'All Products')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Fish')]")).Click();
            string ProductNameValue = driver.FindElement(By.Id("ProductName")).GetAttribute("value");
            Assert.AreEqual("Fish", ProductNameValue);
            string CategoryIdValue = driver.FindElement(By.Id("CategoryId")).GetAttribute("value");
            Assert.AreEqual("8", CategoryIdValue);
            string SupplierIdValue = driver.FindElement(By.Id("SupplierId")).GetAttribute("value");
            Assert.AreEqual("4", SupplierIdValue);
            string QuantityPerUnitValue = driver.FindElement(By.Id("QuantityPerUnit")).GetAttribute("value");
            Assert.AreEqual("1", QuantityPerUnitValue);
            string UnitsInStockValue = driver.FindElement(By.Id("UnitsInStock")).GetAttribute("value");
            Assert.AreEqual("10", UnitsInStockValue);
            string UnitsOnOrderValue = driver.FindElement(By.Id("UnitsOnOrder")).GetAttribute("value");
            Assert.AreEqual("3", UnitsOnOrderValue);
            string ReorderLevelValue = driver.FindElement(By.Id("ReorderLevel")).GetAttribute("value");
            Assert.AreEqual("1", ReorderLevelValue);
        }

        [Test]
        public void AddNewProductTest()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'All Products')]")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Create new')]")).Click();
            driver.FindElement(By.Id("ProductName")).SendKeys("Fish");
            driver.FindElement(By.Id("CategoryId")).SendKeys("Seafood");
            driver.FindElement(By.Id("SupplierId")).SendKeys("Tokyo Traders");
            driver.FindElement(By.Id("UnitPrice")).SendKeys("7");
            driver.FindElement(By.Id("QuantityPerUnit")).SendKeys("1");
            driver.FindElement(By.Id("UnitsInStock")).SendKeys("10");
            driver.FindElement(By.Id("UnitsOnOrder")).SendKeys("3");
            driver.FindElement(By.Id("ReorderLevel")).SendKeys("1");
            driver.FindElement(By.Id("Discontinued")).Click();
            driver.FindElement(By.CssSelector(".btn")).Click();
            var TitleValue = driver.FindElement(By.CssSelector("h2")).Text; 
            Assert.AreEqual("All Products", TitleValue);
        }

        [Test]
        public void LoginTest()
        {

            var TitleValue = driver.FindElement(By.CssSelector("h2")).Text;
            Assert.AreEqual("Home page", TitleValue);
        }

        [TearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}