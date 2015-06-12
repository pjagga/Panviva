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
            wait.Until((d) => { return d.Title.Contains("CPA Australia - Sign in or create an account"); }); 

        }

        public void SetCustomerID(string customerID)
        {
            UICommon.SetValue(By.Id("UserName"), customerID, d);
        }

        public void SetPassword(string password)
        {
            UICommon.SetValue(By.Id("Password"), password, d);
        }

        public void ClickSubmitButton()
        {
            UICommon.ClickButton(By.XPath("//button[@type='submit']"), d);

        }
        
    }
}
