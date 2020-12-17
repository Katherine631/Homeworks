using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    class NewProductPage : OpenedProductPage
    {

        public NewProductPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
        
                
        public void CreateNewProduct(string ProductName, string CategoryId, string SupplierId, string UnitPrice, string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel)
        {
            new Actions(driver).SendKeys(FldProductName, ProductName).Build().Perform();
            new Actions(driver).SendKeys(FldCategoryId, CategoryId).Build().Perform();
            new Actions(driver).SendKeys(FldSupplierId, SupplierId).Build().Perform();
            new Actions(driver).SendKeys(FldUnitPrice, UnitPrice).Build().Perform();
            new Actions(driver).SendKeys(FldQuantityPerUnit, QuantityPerUnit).Build().Perform();
            new Actions(driver).SendKeys(FldUnitsInStock, UnitsInStock).Build().Perform();
            new Actions(driver).SendKeys(FldUnitsOnOrder, UnitsOnOrder).Build().Perform();
            new Actions(driver).SendKeys(FldReorderLevel, ReorderLevel).Build().Perform();
            new Actions(driver).Click(FldDiscontinued).Build().Perform();
            new Actions(driver).Click(SendBtn).Build().Perform();
        }
    }
}