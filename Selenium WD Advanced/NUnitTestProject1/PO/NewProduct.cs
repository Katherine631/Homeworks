using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    class NewProduct : OpenedProductPage
    {
        public bool isNewProduct;
        public NewProduct(IWebDriver driver, bool isNewProduct) : base(driver)
        {
            this.isNewProduct = isNewProduct;
        }
                
        public override void EditProductPage(string ProductName, string CategoryId, string SupplierId, string UnitPrice, string QuantityPerUnit, string UnitsInStock, string UnitsOnOrder, string ReorderLevel)
        {
            new Actions(driver).MoveToElement(ProductName1).SendKeys(ProductName).Build().Perform();
            new Actions(driver).MoveToElement(CategoryId1).SendKeys(CategoryId).Build().Perform();
            new Actions(driver).MoveToElement(SupplierId1).SendKeys(SupplierId).Build().Perform();
            new Actions(driver).MoveToElement(UnitPrice1).SendKeys(UnitPrice).Build().Perform();
            new Actions(driver).MoveToElement(QuantityPerUnit1).SendKeys(QuantityPerUnit).Build().Perform();
            new Actions(driver).MoveToElement(UnitsInStock1).SendKeys(UnitsInStock).Build().Perform();
            new Actions(driver).MoveToElement(UnitsOnOrder1).SendKeys(UnitsOnOrder).Build().Perform();
            new Actions(driver).MoveToElement(ReorderLevel1).SendKeys(ReorderLevel).Build().Perform();
            new Actions(driver).MoveToElement(Discontinued).Click().Build().Perform();
            new Actions(driver).MoveToElement(SendBtn).Click().Build().Perform();
        }
    }
}