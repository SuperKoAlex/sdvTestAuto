using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace sdvAutomation.Tests
{
    public class FirstTest
    {
        [Test]
        public void FistTest()
        {
            Assert.That(1, Is.EqualTo(1));
        }
        [Test]
        public void FirstSeleniumTest()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.nbc.com");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            driver.Quit();
        }
    }
}