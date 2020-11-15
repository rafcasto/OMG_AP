using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace OMG_AP.Pages
{
   public class BasePage
    {
        public IWebDriver driver;
        private WebDriverWait _wait;
        public BasePage(IWebDriver driver) {
            this.driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void NavigateTo(string page) 
        {
            driver.Url = page; 
        }


        public IWebElement FindElementBy(By locator) 
        {       
            return _wait.Until(drv => drv.FindElement(locator));         
        }

        public List<IWebElement> FindElementsBy(By locator) 
        {
           var elements = _wait.Until(drv => drv.FindElements(locator));
            return elements.ToList() ;
        }
    }
}
