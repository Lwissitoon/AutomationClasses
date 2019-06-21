using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using Demo_framework.PageObject;
using Demo_framework.Helpers;


namespace Demo_framework
{
    [TestClass]
    public class UnitTest1
    {


        [TestInitialize]
        public void SetUp()
        {

            ControllerClass.Init();

        }

        [TestMethod]
        public void Test1()
        {
           ControllerClass.Google.GoogleSeachBox.IsPresent();


            Assert.IsTrue(ControllerClass.Google.GoogleSeachBox.Displayed);
        }

        [TestMethod]
        public void Test2()
        {
       
            Thread.Sleep(5000);
        }


        [TestCleanup]
        public void Close()
        {
            ControllerClass.driver.Quit();
        }
    }
}
