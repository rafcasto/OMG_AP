using BoDi;
using OMG_AP.Models;
using OMG_AP.Pages;
using OMG_AP.Pages.Admin;
using OMG_AP.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace OMG_AP.StepDef
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver driver;
        public Hooks(IObjectContainer context) 
        {
            _objectContainer = context;
        
            
        }
        [BeforeScenario]
        public void BeforeScenario() 
        {
            driver  = new ChromeDriver();
            Context context = new Context();
            context.Users = ReadFromJson.ReadUsers(); 
            driver.Url = ReadFromJson.GetEnvironment().Url;
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);            
            _objectContainer.RegisterInstanceAs<Context>(context);
            InitializingPages();
        }

        [AfterScenario]
        public void AfterScenario() 
        {
            driver.Close();
            driver.Dispose();
            driver.Quit();
        }


        private void InitializingPages() 
        {
            _objectContainer.RegisterInstanceAs<MenuDashboardPage>(new MenuDashboardPage(driver));
            _objectContainer.RegisterInstanceAs<BaseAdminPage>(new BaseAdminPage(driver));
            _objectContainer.RegisterInstanceAs<BasePage>(new BasePage(driver));
            _objectContainer.RegisterInstanceAs<LoginAdminPage>(new LoginAdminPage(driver));
        }
    }
}
