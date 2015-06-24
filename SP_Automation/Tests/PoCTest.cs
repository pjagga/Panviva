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
    public class PoCTest : BaseTest
    {
        public PoCTest()
        {

        }


        [TestCategory("Regression")]
        [TestMethod]
        public void SupportPointDoStuff()
        {

            //Log on to site as user.
            InitialPage initialPage = new InitialPage(driver);
            string BaseWindow = driver.CurrentWindowHandle;
            UICommon.SwitchToNewBrowserWithTitle(driver, BaseWindow, "Login");
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetUserName("Paul");
            loginPage.SetPassword("p");
            loginPage.ClickLogOnButton();
            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.GetWelcomeTitleDisplayProperty());
            homePage.ClickFolderNavButton();
            FoldersPage foldersPage = new FoldersPage(driver);
            Assert.IsTrue(foldersPage.GetFoldersDisplayProperty());
        }

    }
}
