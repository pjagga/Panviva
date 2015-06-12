using Microsoft.VisualStudio.TestTools.UnitTesting;
using SP_Automation.PageModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.Tests
{
    [TestClass]
    public class CPALoginTest : BaseTest
    {
        public CPALoginTest()
        {

        }


        [TestCategory("Regression")]
        [TestMethod]
        public void SuccessfulLogin()
        {

            //Log on to site as user.
            CertificateErrorPage certificateErrorPage = new CertificateErrorPage(driver);
            certificateErrorPage.ClickContinueLink();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.SetUserName("Paul");
            loginPage.SetPassword("p");
            loginPage.ClickLogOnButton();
            HomePage homePage = new HomePage(driver);
            
        }

    }
}
