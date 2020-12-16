using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    abstract class OpenedProductPage
    {
        public IWebDriver driver;
 
        public OpenedProductPage(IWebDriver driver)
   
        {
            this.driver = driver;
        }
        public IWebElement ProductName1 => driver.FindElement(By.Id("ProductName"));
        public IWebElement CategoryId1 => driver.FindElement(By.Id("CategoryId"));
        public IWebElement SupplierId1 => driver.FindElement(By.Id("SupplierId"));
        public IWebElement UnitPrice1 => driver.FindElement(By.Id("UnitPrice"));
        public IWebElement QuantityPerUnit1 => driver.FindElement(By.Id("QuantityPerUnit"));
        public IWebElement UnitsInStock1 => driver.FindElement(By.Id("UnitsInStock"));
        public IWebElement UnitsOnOrder1 => driver.FindElement(By.Id("UnitsOnOrder"));
        public IWebElement ReorderLevel1 => driver.FindElement(By.Id("ReorderLevel"));
        public IWebElement Discontinued => driver.FindElement(By.Id("Discontinued"));
        public IWebElement SendBtn => driver.FindElement(By.CssSelector (".btn"));
        

        
    }
}
