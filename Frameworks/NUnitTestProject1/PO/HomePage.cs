using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage (IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement HeadText => driver.FindElement(By.XPath("//h2"));
        private IWebElement AllProductsLink => driver.FindElement(By.LinkText("All Products"));

        public string CurrentHead()
        {
            return HeadText.Text;
        }

        public void ProductsPage ()
        {
            new Actions(driver).MoveToElement(AllProductsLink).Click(AllProductsLink).Build().Perform();
        }
    }
}
