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
      //  public string ProductName;
     //   public string CategoryId;
     //   public string SupplierId;
      //  public string UnitPrice;
     //   public string QuantityPerUnit;
      //  public string UnitsInStock;
     //   public string UnitsOnOrder;
      //  public string ReorderLevel;

        public OpenedProductPage(IWebDriver driver)
        //, string ProductName, string CategoryId, string SupplierId, string UnitPrice, string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel
        {
            this.driver = driver;
           // this.ProductName = ProductName;
           // this.CategoryId = CategoryId;
           // this.SupplierId = SupplierId;
           // this.UnitPrice = UnitPrice;
           // this.UnitsInStock = UnitsInStock;
           // this.UnitsOnOrder = UnitsOnOrder;
           // this.ReorderLevel = ReorderLevel;

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
        public string ProductNameValue()
        {
            return ProductName1.GetAttribute("value");
        }
        public string CategoryIdValue()
        {
            return CategoryId1.GetAttribute("value");
        }
        public string SupplierIdValue()
        {
            return SupplierId1.GetAttribute("value");
        }
        public string UnitPriceValue()
        {
            return UnitPrice1.GetAttribute("value");
        }
        public string QuantityPerUnitValue()
        {
            return QuantityPerUnit1.GetAttribute("value");
        }
        public string UnitsInStockValue()
        {
            return UnitsInStock1.GetAttribute("value");
        }
        public string UnitsOnOrderValue()
        {
            return UnitsOnOrder1.GetAttribute("value");
        }
        public string ReorderLevelValue()
        {
            return ReorderLevel1.GetAttribute("value");
        }
        public string DiscontinuedValue()
        {
            return Discontinued.GetAttribute("checked");
        }
        public void ProductsPage()
        {
            new Actions(driver).MoveToElement(SendBtn).Click(SendBtn).Build().Perform();
        }

        abstract public void EditProductPage(string ProductName, string CategoryId, string SupplierId, string UnitPrice, string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel);
        
    }
}
