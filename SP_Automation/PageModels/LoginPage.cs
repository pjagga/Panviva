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
    class LoginPage : BasePage
    {
        IWebDriver d;
        public LoginPage(IWebDriver driver)
            : base(driver)
        {
            this.d = driver; 
            //Wait for title to be displayed 
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            wait.Until((d) => { return d.Title.Contains("Login : SupportPoint"); }); 

        }

        public void SetUserName(string username)
        {
            UICommon.SetValue(By.Id("UserName"), username, d);
        }

        public void SetPassword(string password)
        {
            UICommon.SetValue(By.Id("Password"), password, d);
        }

        public void ClickLogOnButton()
        {
            UICommon.ClickButton(By.XPath("//button[@type='submit']"), d);

        }
        
    }
}
