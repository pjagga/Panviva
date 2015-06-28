using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP_Automation.Commons;
using SP_Automation.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SP_Automation.Tests
{
    [TestClass]
    public class LoginTest : BaseTest
    {
        public LoginTest()
        {

        }


        [TestCategory("Regression")]
        [TestMethod]

        public void SuccessfulLogin()
        {

            //Log on to site as user.
            InitialPage initialPage = new InitialPage(driver);
            string BaseWindow = driver.CurrentWindowHandle;
            UICommon.SwitchToNewBrowserWithTitle(driver, BaseWindow, "Login");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetUserName("Paa");
            loginPage.SetPassword("Admin@123");
            loginPage.ClickLogOnButton();
            //loginPage.GetObjValue();
            HomePage homePage = new HomePage(driver);

        }

        [TestCategory("Regression")]
        [TestMethod]
        public void NegativeTest(){
            //Login Fails for Incorrect Passwords
            String errorMessage = "Login failed, please try again.";
            InitialPage initialPage = new InitialPage(driver);
            string BaseWindow = driver.CurrentWindowHandle;
            UICommon.SwitchToNewBrowserWithTitle(driver, BaseWindow, "Login");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetUserName("Paul");
            loginPage.SetPassword("x");
            loginPage.ClickLogOnButton();
            loginPage.LoginFailedMessage(errorMessage);
            
    }

        [TestCategory("Regression")]
        [TestMethod]
        public void ClickSP()
        {
            InitialPage initialPage = new InitialPage(driver);
            string BaseWindow = driver.CurrentWindowHandle;
            UICommon.SwitchToNewBrowserWithTitle(driver, BaseWindow, "Login");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetUserName("Paa");
            loginPage.SetPassword("Admin@123");
            loginPage.ClickLogOnButton();
           // string Window = driver.CurrentWindowHandle;
           // UICommon.SwitchToNewBrowserWithTitle(driver, Window, "Home");
            HomePage homePage = new HomePage(driver);
            string Window = driver.CurrentWindowHandle;
            System.Console.WriteLine(driver.Title);
            homePage.ClickSPManager();
            UICommon.SwitchToNewBrowserWithTitle(driver, Window, "SupportPoint");
            AuthorPage authorPage = new AuthorPage(driver);
            DocumentPage documentPage = new DocumentPage(driver);
            documentPage.setName("Hello_World");

        }

    }
}
