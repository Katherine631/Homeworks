using NUnit.Framework;
using NUnitTestProject1.PO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        private LoginPage LoginPage;
        private HomePage HomePage;
        private ProductsPage ProductsPage;
        

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
           
        }

        [Test, Order(1)]
        public void LoginTest()
        {
            LoginPage = new LoginPage(driver);
            LoginPage.Login("user", "user");
            HomePage = new HomePage(driver);
            Assert.AreEqual("Home page", HomePage.CurrentHead());
        }

        [Test, Order(2)]
        public void AddNewProductTest()
        {
            HomePage.ProductsPage();
            ProductsPage = new ProductsPage(driver);
            ProductsPage.OpenNewProduct();
            NewProductPage newProductPage1 = new NewProductPage(driver);
            newProductPage1.CreateNewProduct("Fish", "Seafood", "Tokyo Traders", "7", "1", "10", "3", "1");

            Assert.AreEqual("All Products", ProductsPage.CurrentHead());
        }
        [Test, Order(3)]
        public void CheckProductTest()
        {

            ProductsPage = new ProductsPage(driver);
            ProductsPage.OpenExistProduct();
            ExistProductPage existProductPage1 = new ExistProductPage(driver);
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Fish", existProductPage1.ProductNameValue());
                Assert.AreEqual("8", existProductPage1.CategoryIdValue());
                Assert.AreEqual("4", existProductPage1.SupplierIdValue());
                Assert.AreEqual("7,0000", existProductPage1.UnitPriceValue());
                Assert.AreEqual("1", existProductPage1.QuantityPerUnitValue());
                Assert.AreEqual("10", existProductPage1.UnitsInStockValue());
                Assert.AreEqual("3", existProductPage1.UnitsOnOrderValue());
                Assert.AreEqual("1", existProductPage1.ReorderLevelValue());
                Assert.AreEqual("true", existProductPage1.DiscontinuedValue());
            });
           
        }

        [Test, Order(4)]
        public void LogoutTest()
        {
            ProductsPage = new ProductsPage(driver);
            ProductsPage.Logout();
            Assert.AreEqual("Login", LoginPage.CurrentHead());
        }
                    
             

        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}