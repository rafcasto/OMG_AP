using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
namespace OMG_AP.Pages.Admin
{
    public class MenuDashboardPage : BaseAdminPage
    {
        private By _menuContainer = By.Id("nav-accordion");
        private By _urlTag = By.TagName("a");
        public MenuDashboardPage(IWebDriver driver) : base(driver)
        {

        }

        public void ClickOnMainMenu(string option) 
        {
            ClickOnMenuOption(option);
        }

        public void ClickOnSubMenu(string option) 
        {
            ClickOnMenuOption(option);
        }

        private void ClickOnMenuOption(string option) 
        {
            var menuContainer = FindElementBy(_menuContainer);
            menuContainer.FindElement(By.LinkText(option)).Click();
        }
    }
}
