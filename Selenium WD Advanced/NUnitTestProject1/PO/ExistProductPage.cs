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
            return FldProductName.GetAttribute("value");
        }
        public string CategoryIdValue()
        {
            return FldCategoryId.GetAttribute("value");
        }
        public string SupplierIdValue()
        {
            return FldSupplierId.GetAttribute("value");
        }
        public string UnitPriceValue()
        {
            return FldUnitPrice.GetAttribute("value");
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
            new Actions(driver).MoveToElement(SendBtn).Click(SendBtn).Build().Perform();
        }

    }
}
