using NUnit.Framework;
using NUnitTestProject1.business_objects;
using NUnitTestProject1.PO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace NUnitTestProject1.step_definitions
{
    [Binding]

    public class FishSteps
    {
        private IWebDriver driver;
        

        [Given(@"I open ""(.+)"" url")]
        public void GivenIOpenLoginPage(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [When(@"I login with ""(.+)"", ""(.+)"" fields")]
        public void WhenILogin(string name, string password)
        {
            new LoginPage(driver).TypeUserInLoginPage(name, password);
            new LoginPage(driver).Login();
        }

        [When(@"I click All Products link")]
        public void WhenIClickAllProductslink()
        {
            new HomePage(driver).ProductsPage();
        }

        [When(@"I click Create new button")]
        public void WhenIClickCreateNewButton()
        {
            new ProductsPage(driver).OpenNewProduct();
        }

        [When(@"I fill next fields ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)"", ""(.+)""")]
        public void WhenIFillNextFields(string ProductName, string CathegoryId, string SupplierId, string UnitPrice, string QuantityPerUnit, string UnitsInStock, string UnitsInOrder, string ReorderLevel)
        {
            Product product = new Product(ProductName, CathegoryId, SupplierId, UnitPrice, QuantityPerUnit, UnitsInStock, UnitsInOrder, ReorderLevel);
            new NewProductPage(driver).CreateNewProduct(product);
        }

        [When(@"I click Send button")]
        public void WhenIClickCreateSendButton()
        {
            new NewProductPage(driver).ClickSendButton();
        }

        [Then(@"The product ""(.+)"" should be created")]
        public void ThenTheProductShouldBeCreated(string name)
        {
            ProductsPage productsPage = new ProductsPage(driver);
            Assert.IsTrue(productsPage.FindName(name));
        } 
        [AfterScenario]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
