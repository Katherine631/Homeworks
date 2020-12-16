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
        private OpenedProductPage OpenedProductPage;
        private NewProduct NewProduct;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
           
        }

        [Test, Order(4)]
        public void LogoutTest()
        {
            ProductsPage = new ProductsPage(driver);
            HomePage.ProductsPage();
            ProductsPage.Logout();
            Assert.AreEqual("Login", LoginPage.CurrentHead());
        }

        [Test, Order(3)]
        public void CheckProductTest()
        {
           
            HomePage.ProductsPage();
          //  ProductsPage.OpenedProductPage();
          //  NewProduct Fish = new NewProduct(driver, true);
            
            Assert.AreEqual("Fish", OpenedProductPage.ProductNameValue());
            Assert.AreEqual("8", OpenedProductPage.CategoryIdValue());
            Assert.AreEqual("4", OpenedProductPage.SupplierIdValue());
            Assert.AreEqual("7,0000", OpenedProductPage.UnitPriceValue());
            Assert.AreEqual("1", OpenedProductPage.QuantityPerUnitValue());
            Assert.AreEqual("10", OpenedProductPage.UnitsInStockValue());
            Assert.AreEqual("3", OpenedProductPage.UnitsOnOrderValue());
            Assert.AreEqual("1", OpenedProductPage.ReorderLevelValue());
            Assert.AreEqual("true", OpenedProductPage.DiscontinuedValue());
        }

        [Test, Order(2)]
        public void AddNewProductTest()
        {
            ProductsPage = new ProductsPage(driver);
            HomePage.ProductsPage();
            ProductsPage.OpenNewProduct();
            NewProduct product1 = new NewProduct(driver, true);
            product1.EditProductPage("Fish","8", "4", "7,0000", "1", "10", "3", "1");
            Assert.AreEqual("All Products", ProductsPage.CurrentHead());
        }

        [Test, Order(1)]
        public void LoginTest()
        {
            LoginPage = new LoginPage(driver);
            LoginPage.Login("user", "user");
            HomePage = new HomePage(driver);                            
            Assert.AreEqual("Home page", HomePage.CurrentHead());
        }

        [OneTimeTearDown]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}