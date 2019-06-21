using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_framework.Helpers
{
   public static class ExplicitWaits
    {
        public static bool IsPresent(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(ControllerClass.driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(element));
                return element.Displayed;
            }
            catch (WebDriverTimeoutException)
            {

                return false;

            }

        }
    }
}
