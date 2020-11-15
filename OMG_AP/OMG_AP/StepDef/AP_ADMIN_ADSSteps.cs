using OMG_AP.Models;
using OMG_AP.Pages.Admin;
using System;
using TechTalk.SpecFlow;

namespace OMG_AP.StepDef
{
    [Binding]
    public class AP_ADMIN_ADSSteps
    {
        private BaseAdminPage _baseAdminPage;
        private LoginAdminPage _loginAdminPage;
        private Context _context;
        private MenuDashboardPage _menuDashboardPage;
        public AP_ADMIN_ADSSteps( BaseAdminPage baseAdminPage, 
                                  LoginAdminPage loginAdminPage,
                                  Context context,
                                  MenuDashboardPage menuDashboardPage
        ) 
        {
            _baseAdminPage = baseAdminPage;
            _loginAdminPage = loginAdminPage;
            _context = context;
            _menuDashboardPage = menuDashboardPage;
        }
        [Given(@"User navigate to the AP's admin website")]
        public void GivenUserNavigateToTheAPSAdminWebsite()
        {
            _baseAdminPage.NavigateToAdminPage();
        }
        
        [Given(@"User Navigates to ""(.*)"" menu")]
        public void GivenUserNavigatesToMenu(string menuOption)
        {
            _menuDashboardPage.ClickOnMainMenu(menuOption);
        }
        
        [Given(@"User clicks on ""(.*)"" submenu")]
        public void GivenUserClicksOnSubmenu(string submenuOption)
        {
            _menuDashboardPage.ClickOnSubMenu(submenuOption);
        }
        
        [When(@"User authenticates as ""(.*)""")]
        public void WhenUserAuthenticatesAs(string permission)
        {
            var user = _context.FindUserBy(permission);
            _loginAdminPage.LoginWith(user.UserName, user.Password);
        }
        
        [When(@"User completes the form")]
        public void WhenUserCompletesTheForm(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User lands in the admin dashboard")]
        public void ThenUserLandsInTheAdminDashboard()
        {
            
        }
        
        [Then(@"User Success message")]
        public void ThenUserSuccessMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
