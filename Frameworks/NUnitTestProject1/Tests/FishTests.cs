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
            HomePage HomePage = Northwind_service.Login(User1, driver);
            Assert.AreEqual("Home page", HomePage.CurrentHead());
        }

        [Test, Order(2)]
        public void AddNewProductTest()
        {
            ProductsPage ProductsPage1 = Northwind_service.AddNewProduct(Fish, driver);
            Assert.AreEqual("All Products", ProductsPage1.CurrentHead());
        }
        [Test, Order(3)]
        public void CheckProductTest()
        {

            ProductsPage = new ProductsPage(driver);
            ProductsPage.OpenExistProduct(Fish);
            ExistProductPage existProductPage1 = new ExistProductPage(driver);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(Fish.ProductName, existProductPage1.ProductNameValue());
                Assert.AreEqual(Fish.CategoryId, existProductPage1.CategoryIdValue());
                Assert.AreEqual(Fish.SupplierId, existProductPage1.SupplierIdValue());
                Assert.AreEqual(Fish.UnitPrice, existProductPage1.UnitPriceValue());
                Assert.AreEqual(Fish.QuantityPerUnit, existProductPage1.QuantityPerUnitValue());
                Assert.AreEqual(Fish.UnitsInStock, existProductPage1.UnitsInStockValue());
                Assert.AreEqual(Fish.UnitsOnOrder, existProductPage1.UnitsOnOrderValue());
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