using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP_Automation.Commons;

namespace SP_Automation.PageModels
{
    class FoldersPage : BasePage
    {
        IWebDriver d;
        public FoldersPage(IWebDriver driver)
            : base(driver)
        {
            this.d = driver;
            //Wait for title to be displayed 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            wait.Until((d) => { return d.Title.Contains("Folders : SupportPoint"); }); 
        }



        internal bool GetFoldersDisplayProperty()
        {
            IWebElement elem = UICommon.GetElement(By.Id("folders"), d);
            return elem.Displayed;

        }
    }
}
