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
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            HomePage homePage = new HomePage(driver);
            homePage.ClickLoginButton();
            LoginPage loginPage = new LoginPage(driver);
            Assert.IsTrue(driver.Title == "CPA Australia - Sign in or create an account");
            loginPage.SetCustomerID("9822090");
            loginPage.SetPassword("01Password");
            loginPage.ClickSubmitButton();
            Assert.IsTrue(driver.Title == "CPA Australia - Home");
            homePage.ClickLogOutButton();

        }

    }
}
