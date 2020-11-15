using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_AP.Pages.Admin
{
    public class LoginAdminPage : BaseAdminPage
    {
        private By _userName = By.Name("userName");
        private By _password = By.Name("userPass");
        private By _loginBtn = By.Name("submit");
        public LoginAdminPage(IWebDriver driver) : base(driver)
        {
        }

        public void LoginWith(string userName, string password) 
        {
            FindElementBy(_userName).SendKeys(userName);
            FindElementBy(_password).SendKeys(password);
            FindElementBy(_loginBtn).Click();
        }
    }
}
