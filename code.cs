using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HybridFramework.TestSuites
{
    [TestClass]
    public class TestCase
    {
        //  public static IWebDriver driver;
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.goibibo.com/flights/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//span[text()= \"From\"]")).SendKeys("Delhi");
            Thread.Sleep(2000);
            driver.Quit();

        }

    }
}
