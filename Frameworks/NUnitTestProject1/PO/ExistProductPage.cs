using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    class ExistProductPage : OpenedProductPage
    {
        private new IWebElement FldCategoryId => driver.FindElement(By.XPath("//*[@id=\"CategoryId\"]/option[9]"));
        private new IWebElement FldSupplierId => driver.FindElement(By.XPath("//*[@id=\"SupplierId\"]/option[5]"));
        public ExistProductPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        public string ProductNameValue()
        {
            return FldProductName.GetAttribute("value");
        }
        public string CategoryIdValue()
        {
            return FldCategoryId.Text; 
            
        }
        public string SupplierIdValue()
        {
            return FldSupplierId.Text;
        }
        public string UnitPriceValue()
        {
            string UnitPriceValue = Math.Round(Convert.ToDecimal(FldUnitPrice.GetAttribute("value"))).ToString();
            return UnitPriceValue;
        }
        public string QuantityPerUnitValue()
        {
            return FldQuantityPerUnit.GetAttribute("value");
        }
        public string UnitsInStockValue()
        {
            return FldUnitsInStock.GetAttribute("value");
        }
        public string UnitsOnOrderValue()
        {
            return FldUnitsOnOrder.GetAttribute("value");
        }
        public string ReorderLevelValue()
        {
            return FldReorderLevel.GetAttribute("value");
        }
        public string DiscontinuedValue()
        {
            return FldDiscontinued.GetAttribute("checked");
        }
        public void ReturnToProductsPage()
        {
            driver.FindElement(By.LinkText("All Products")).Click();
        }
        

    }
}
