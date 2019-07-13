using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantis_tests
{
    public class NavigatorHelper : HelperBase
    {
        private string baseURL;

        public NavigatorHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.manager = manager;
            this.baseURL = baseURL;
        }

        public void OpenManagePage()
        {
            driver.Navigate().GoToUrl(baseURL + "manage_overview_page.php");
        }

        public void OpenManageProjectsPage()
        {
            driver.Navigate().GoToUrl(baseURL + "manage_proj_page.php");
        }

        public void OpenLoginPage()
        {
            driver.Navigate().GoToUrl(baseURL + "/mantisbt-2.21.1/login_page.php");
        }
    }
}
