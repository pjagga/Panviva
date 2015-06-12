using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using SP_Automation.Environments;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.Tests
{
    [TestClass]
    public abstract class BaseTest
    {
        protected static IWebDriver driver;
        protected TestEnvironment environment;
        
        
        [TestInitialize]
        public void Initialize()
        {
            var options = new InternetExplorerOptions()
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };

            switch (Properties.Settings.Default.Browser)
            {
                case BrowserType.IE:
                    driver = new InternetExplorerDriver(options);
                    break;
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser Type Invalid");
            }

            driver.Navigate().GoToUrl(TestEnvironment.GetEnvironment().Url);
            driver.Manage().Window.Maximize();

        }

        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
            switch (Properties.Settings.Default.Browser)
            {
                case BrowserType.IE:
                    KillProcess("iexplorer.exe");
                    break;
                case BrowserType.Chrome:
                    KillProcess("chrome.exe");
                    break;
                default:
                    throw new ArgumentException("Browser Type Invalid");

            }
        }

        public static void KillProcess(string processName)
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                process.Kill();
            }
        }
    }
}
