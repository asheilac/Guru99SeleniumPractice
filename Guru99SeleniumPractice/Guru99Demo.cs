using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

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

        [Test]
        public void TestCanGoToAdmiraltyAndClickAccessibility()
        {
            driver.Url = "https://www.admiralty.co.uk/";
            driver.Manage().Window.Maximize();
            
            IWebElement accessibilityElement =
                driver.FindElement(By.XPath("/html/body/div[1]/div[3]/footer/div/div/div/div[2]/ul/li[1]/a"));

            Actions action = new Actions(driver);
            action.MoveToElement(accessibilityElement);

            accessibilityElement.Click();

            string title = driver.Title;

            Assert.That(title, Is.EqualTo("Accessibility | ADMIRALTY"));
        }

        [Test]
        public void TestCanGoToDemoBlazeAndClickCart()
        {
            driver.Url = "https://www.demoblaze.com/index.html";
            driver.Manage().Window.Maximize();

            IWebElement cartElement = driver.FindElement(By.XPath("//*[@id=\"cartur\"]"));

            cartElement.Click();

            string title = driver.Title;

            Assert.That(title, Is.EqualTo("STORE"));
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }
    }
}
