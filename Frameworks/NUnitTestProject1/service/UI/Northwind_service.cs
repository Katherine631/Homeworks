﻿using NUnitTestProject1.business_objects;
using NUnitTestProject1.PO;
using OpenQA.Selenium;



namespace NUnitTestProject1.services
{
    class Northwind_service
    {
        
        public static ProductsPage AddNewProduct (Product product, IWebDriver driver)
        {
            HomePage HomePage = new HomePage(driver);
            HomePage.ProductsPage();
            ProductsPage ProductsPage = new ProductsPage(driver);
            ProductsPage.OpenNewProduct();
            NewProductPage NewProductPage = new NewProductPage(driver);
            NewProductPage.CreateNewProduct(product);
            ProductsPage ProductsPage1 = new ProductsPage(driver);
            return ProductsPage1;


        }
        public static HomePage Login(User user, IWebDriver driver)
        {
            LoginPage LoginPage = new LoginPage(driver);
            LoginPage.Login(user.Name, user.Password);
            HomePage HomePage = new HomePage(driver);
            return HomePage;
        }
    }
}
