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
        private IWebElement ExistProduct => driver.FindElement(By.XPath("//a[contains(text(),'Fish')]"));
<<<<<<< HEAD
       // private IWebElement Remove_product => driver.FindElement(By.XPath("xpath=//*[a=product]/following-sibling::*[a='Remove']/a"));
=======
>>>>>>> SeleniumWDadvanced
        private IWebElement LogoutBtn => driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
        private IWebElement HeadText => driver.FindElement(By.XPath("//h2"));

        public void OpenExistProduct ()
        {
<<<<<<< HEAD
            new Actions(driver).MoveToElement(ExistProduct).Click(ExistProduct).Build().Perform();
=======
                   
           new Actions(driver).MoveToElement(ExistProduct).Click(ExistProduct).Build().Perform();
>>>>>>> SeleniumWDadvanced
        }
        public void OpenNewProduct()
        {
            new Actions(driver).MoveToElement(CreateNewBtn).Click(CreateNewBtn).Build().Perform();
        }
        public void Logout()
        {
            new Actions(driver).MoveToElement(LogoutBtn).Click(LogoutBtn).Build().Perform();
        }
        public string CurrentHead()
        {
            return HeadText.Text;
        }



    }

   
}
