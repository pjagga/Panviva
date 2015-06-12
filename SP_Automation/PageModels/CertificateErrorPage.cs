using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SP_Automation.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.PageModels
{
    class CertificateErrorPage : BasePage
    {
        IWebDriver d;
        public CertificateErrorPage(IWebDriver driver)
            : base(driver)
        {
            this.d = driver; 
            //Wait for title to be displayed 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            wait.Until((d) => { return d.Title.Contains("Certificate Error: Navigation Blocked"); }); 

        }

        

        public void ClickContinueLink()
        {
            UICommon.ClickLink(By.Id("overridelink"), d);

        }
        
    }
}
