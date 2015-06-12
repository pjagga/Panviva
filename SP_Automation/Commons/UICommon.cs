using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.Commons
{
    public class UICommon
    {
        public static IWebElement GetElement(By searchType, IWebDriver d)
        {

            WebDriverWait wait = new WebDriverWait(d, TimeSpan.FromSeconds(Properties.Settings.Default.WaitTime));
            IWebElement elem = wait.Until(ExpectedConditions.ElementIsVisible(searchType));
            elementHighlight(elem, d);
            return elem;

        }

        public static void ClickButton(By searchType, IWebDriver d)
        {
            IWebElement elem = GetElement(searchType, d);
            elem.Click();
        }

        public static void SetValue(By searchType, string value, IWebDriver d)
        {
            IWebElement elem = GetElement(searchType, d);
            elem.Clear();
            elem.SendKeys(value);

        }

        public static void elementHighlight(IWebElement element, IWebDriver d)
        {
           if (element.TagName != "a")
            {
                var jsDriver = (IJavaScriptExecutor)d;
                string highlightJavascript = @"$(arguments[0]).css({ ""border-width"" : ""2px"", ""border-style"" : ""solid"", ""border-color"" : ""red"" });";
                jsDriver.ExecuteScript(highlightJavascript, new object[] { element });
            }
        }

        internal static void ClickLink(By by, IWebDriver d)
        {
            IWebElement elem = GetElement(by, d);
            elem.Click();
        }
    }
}
