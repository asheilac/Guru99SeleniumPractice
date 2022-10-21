﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Guru99SeleniumPractice
{
    public class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Tools");
        }

        [Test]
        public void Test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [Test]
        public void TestCanGoToGuru99AndClickTesting()
        {
            driver.Url = "http://demo.guru99.com/test/guru99home/";

            IWebElement testingElement =
                driver.FindElement(By.XPath("//*[@id=\"rt-header\"]/div/div[2]/div/ul/li[2]/a"));
            testingElement.Click();
            string title = driver.Title;

            Assert.That(title, Is.EqualTo("Software Testing Tutorial"));
        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
