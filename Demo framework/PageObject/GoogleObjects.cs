using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_framework.PageObject
{
  public   class GoogleObjects
    {
        public GoogleObjects(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How =How.Name,Using ="q")]
        public IWebElement GoogleSeachBox { get; set; }
    }
}
