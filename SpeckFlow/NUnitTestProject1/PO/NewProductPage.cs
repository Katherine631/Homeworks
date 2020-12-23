using NUnitTestProject1.business_objects;
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
        
                
        public void CreateNewProduct(Product product)
        {
            new Actions(driver).SendKeys(FldProductName, product.ProductName).Build().Perform();
            new Actions(driver).SendKeys(FldCategoryId, product.CategoryId).Build().Perform();
            new Actions(driver).SendKeys(FldSupplierId, product.SupplierId).Build().Perform();
            new Actions(driver).SendKeys(FldUnitPrice, product.UnitPrice).Build().Perform();
            new Actions(driver).SendKeys(FldQuantityPerUnit, product.QuantityPerUnit).Build().Perform();
            new Actions(driver).SendKeys(FldUnitsInStock, product.UnitsInStock).Build().Perform();
            new Actions(driver).SendKeys(FldUnitsOnOrder, product.UnitsOnOrder).Build().Perform();
            new Actions(driver).SendKeys(FldReorderLevel, product.ReorderLevel).Build().Perform();
            new Actions(driver).Click(FldDiscontinued).Build().Perform();
            
        }

        public void ClickSendButton()
        {
            new Actions(driver).Click(SendBtn).Build().Perform();
        }
    }
}