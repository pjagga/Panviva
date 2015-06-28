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
    class DocumentPage : BasePage
    {
        IWebDriver d;
        public DocumentPage(IWebDriver driver)
            : base(driver)
        {
            this.d = driver;
            //Wait for title to be displayed 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            wait.Until((d) => { return d.Title.Contains("Document : SupportPoint"); }); 
        }

        public void setName(string value)
        {
            WebDriverWait wait = new WebDriverWait(d, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            wait.Until(drv => drv.FindElement(By.XPath("//input[@type='text'][@name='name']")));
            UICommon.SetValue(By.XPath("//input[@type='text'][@name='name']"), value, d);
        }
    }
}
