using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.PageModels
{
    public abstract class BasePage
    {
        protected IWebDriver d;
        public BasePage(IWebDriver driver)
        {
            this.d = driver;
            d.SwitchTo().DefaultContent();
            d.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(60));
        }


    }
}
