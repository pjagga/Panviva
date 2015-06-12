﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SP_Automation.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.PageModels
{
    class HomePage : BasePage
    {
        IWebDriver d;
        public HomePage(IWebDriver driver)
            : base(driver)
        {
            this.d = driver;
            //Wait for title to be displayed 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            wait.Until((d) => { return d.Title.Contains("Home : SupportPoint"); }); 
        }

        public void ClickLoginButton()
        {
            UICommon.ClickButton(By.Id("login_btn"), d);

        }


        internal void ClickLogOutButton()
        {
            UICommon.ClickButton(By.Id("logout_btn"), d);
        }
    }
}
