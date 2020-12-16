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
            new Actions(driver).SendKeys(ProductName1, ProductName).Build().Perform();
            new Actions(driver).SendKeys(CategoryId1, CategoryId).Build().Perform();
            new Actions(driver).SendKeys(SupplierId1, SupplierId).Build().Perform();
            new Actions(driver).SendKeys(UnitPrice1, UnitPrice).Build().Perform();
            new Actions(driver).SendKeys(QuantityPerUnit1, QuantityPerUnit).Build().Perform();
            new Actions(driver).SendKeys(UnitsInStock1, UnitsInStock).Build().Perform();
            new Actions(driver).SendKeys(UnitsOnOrder1, UnitsOnOrder).Build().Perform();
            new Actions(driver).SendKeys(ReorderLevel1, ReorderLevel).Build().Perform();
            new Actions(driver).Click(Discontinued).Build().Perform();
            new Actions(driver).Click(SendBtn).Build().Perform();
        }
    }
}