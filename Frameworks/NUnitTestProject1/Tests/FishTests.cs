using NUnit.Framework;
using NUnitTestProject1.business_objects;
using NUnitTestProject1.PO;
using NUnitTestProject1.services;
using NUnitTestProject1.Tests;


namespace NUnitTestProject1
{
    [TestFixture]
    public class FishTests: BaseTests
    {
        
        private ProductsPage ProductsPage;
        private Product Fish = new Product("Fish", "Seafood", "Tokyo Traders", "7", "1", "10", "3", "1");
        private User User1 = new User("user", "user");
        

        

        [Test, Order(1)]
        public void LoginTest()
        {
            Assert.AreEqual("Home page", Northwind_service.Registration(User1, driver));
        }

        [Test, Order(2)]
        public void AddNewProductTest()
        {
            Assert.AreEqual("All Products", Northwind_service.AddNewProduct(Fish, driver));
        }
        [Test, Order(3)]
        public void CheckProductTest()
        {

            ProductsPage = new ProductsPage(driver);
            ProductsPage.OpenExistProduct(Fish);
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
            Assert.AreEqual("Login", ProductsPage.Logout());
        }
                    
             

        
    }
}