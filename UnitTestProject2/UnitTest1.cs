using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;



namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver _driver;
        [TestMethod]
        public void TestMethod1()
        {
            var outPutDirectory = 
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            _driver = new ChromeDriver(outPutDirectory);
            _driver.Navigate().GoToUrl("https://www.cii.in/OnlineRegistration.aspx");
            var textArea = _driver.FindElement(By.Name("drpAttendee"));
            var selectElement = new SelectElement(textArea);
            selectElement.SelectByValue("3");
            var selectAd = _driver.FindElement(By.Id("Gridview1_ctl02_drpTitle"));
            var valueOfAd = new SelectElement(selectAd);
            valueOfAd.SelectByValue("Admiral");
            Thread.Sleep(3000);
        

          
        }
        [TestCleanup]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
