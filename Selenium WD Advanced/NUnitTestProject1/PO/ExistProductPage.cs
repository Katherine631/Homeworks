using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.PO
{
    class ExistProductPage : OpenedProductPage
    {
        public ExistProductPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }
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
            new Actions(driver).SendKeys(UnitPrice1, "7").Build().Perform();
            new Actions(driver).MoveToElement(SendBtn).Click(SendBtn).Build().Perform();
        }

    }
}
