using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Szkolenie032020
{
    public class Tests
    {
        ChromeDriver driver;

        [Test]
        public void GoogleSearchTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Name("q")).SendKeys("Look4Up");

            Thread.Sleep(500);

            driver.FindElement(By.Name("btnK")).Click();

            var aaa = driver.Title;

            Assert.That(aaa.Contains("Look4Up"));

            driver.Quit();
        }
    }
}
