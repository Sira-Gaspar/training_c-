using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace mantis_tests
{
    public class ApplicationManager
    {
        public IWebDriver driver;
        protected string baseURL;

        public RegistrationHelper Registration { get; set; }
        public FTPHelper Ftp { get; set; }
        public JamesHelper James { get; set; }
        public MailHelper Mail { get; set; }
        public LoginHelper loginHelper;
        public NavigatorHelper navigator;
        public ProjectHelper projectHelper;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";
            Registration = new RegistrationHelper(this);
            Ftp = new FTPHelper(this);
            James = new JamesHelper(this);
            Mail = new MailHelper(this);
            projectHelper = new ProjectHelper(this);
            navigator = new NavigatorHelper(this, baseURL);
            loginHelper = new LoginHelper(this);
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        ~ApplicationManager()
        {            
                try
                {
                    driver.Quit();
                }
                catch (Exception)
                {
                    //Ignore errors if unable to close the browser
                }
        }
        
        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.driver.Url = "http://localhost/mantisbt-2.21.1/mantisbt-2.21.1/login_page.php";
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get { return driver; }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigatorHelper Navigator
        {
            get { return navigator; }
        }
        public ProjectHelper Project
        {
            get { return projectHelper; }
        }
    }
}
