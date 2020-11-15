using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OMG_AP.Pages.Admin
{
    public class BaseAdminPage : BasePage
    {
        public BaseAdminPage(IWebDriver driver) : base(driver)
        {

        }

        public void NavigateToAdminPage() 
        {
            driver.Url = driver.Url + "/admin-add-deals";
        }

    }
}
