using Demo_framework.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_framework.Helpers;

namespace Demo_framework
{
   public static class ControllerClass
    {
        public static GoogleObjects Google;
        public static IWebDriver driver;

        public static void Init()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Google = new GoogleObjects(driver);

        }
    }
}
