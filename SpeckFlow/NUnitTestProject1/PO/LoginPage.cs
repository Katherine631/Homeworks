using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;


namespace NUnitTestProject1.PO
{
    class LoginPage 
    {
        private IWebDriver driver;
        public LoginPage (IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement InputName => driver.FindElement(By.CssSelector("[for=Name] +input"));
        private IWebElement InputPassword => driver.FindElement(By.CssSelector("[for=Password] +input"));
        private IWebElement SendBtn => driver.FindElement(By.CssSelector(".btn"));
        private IWebElement HeadText => driver.FindElement(By.CssSelector("h2"));

        public void Login()
        {
        //   new Actions(driver).SendKeys(InputName, name).Build().Perform();
        //   new Actions(driver).SendKeys(InputPassword, password).Build().Perform();
           new Actions(driver).MoveToElement(SendBtn).Click(SendBtn).Build().Perform();
            
        }

       // public void ClickSendBtn()
       // {
       //     new Actions(driver).MoveToElement(SendBtn).Click(SendBtn).Build().Perform();
       // }

       public void TypeUserInLoginPage (string name, string password)
        {
            InputName.SendKeys(name);
            InputPassword.SendKeys(password);
        }

        public string CurrentHead()
        {
            return HeadText.Text;
        }
    }

    
}
