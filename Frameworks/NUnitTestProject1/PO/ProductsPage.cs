using NUnitTestProject1.business_objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    class ProductsPage
    {
        private IWebDriver driver;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement CreateNewBtn => driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
        private IWebElement LogoutBtn => driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
        private IWebElement HeadText => driver.FindElement(By.XPath("//h2"));

        public void OpenExistProduct (Product product)
        {
            driver.FindElement(By.LinkText (product.ProductName)).Click();
        }
        public void OpenNewProduct()
        {
            new Actions(driver).MoveToElement(CreateNewBtn).Click(CreateNewBtn).Build().Perform();
        }
        
        public string CurrentHead()
        {
            return HeadText.Text;
        }

        public string Logout()
        {
            new Actions(driver).MoveToElement(LogoutBtn).Click(LogoutBtn).Build().Perform();
            LoginPage loginPage = new LoginPage(driver);
            return loginPage.CurrentHead();
        }

    }

   
}
