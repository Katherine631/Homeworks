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
        public IWebElement FldProductName => driver.FindElement(By.Id("ProductName"));
        public IWebElement FldCategoryId => driver.FindElement(By.Id("CategoryId"));
        public IWebElement FldSupplierId => driver.FindElement(By.Id("SupplierId"));
        public IWebElement FldUnitPrice => driver.FindElement(By.Id("UnitPrice"));
        public IWebElement FldQuantityPerUnit => driver.FindElement(By.Id("QuantityPerUnit"));
        public IWebElement FldUnitsInStock => driver.FindElement(By.Id("UnitsInStock"));
        public IWebElement FldUnitsOnOrder => driver.FindElement(By.Id("UnitsOnOrder"));
        public IWebElement FldReorderLevel => driver.FindElement(By.Id("ReorderLevel"));
        public IWebElement FldDiscontinued => driver.FindElement(By.Id("Discontinued"));
        public IWebElement SendBtn => driver.FindElement(By.CssSelector (".btn"));
        

        
    }
}
