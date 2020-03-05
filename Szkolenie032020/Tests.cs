using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

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

        [Test]
        public void SearchByAllSelectors()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://www.phptravels.net/home");

            var header = driver.FindElement(By.Id("header-waypoint-sticky"));

            var arrow = driver.FindElement(By.ClassName("slick-next"));

            var search = driver.FindElement(By.CssSelector("#hotels .btn-block"));

            var visa = driver.FindElement(By.XPath("//*[@id=\"mobileMenuMain\"]/nav/ul[2]/li[1]/a"));

            var buttonBar = driver.FindElement(By.ClassName("menu-horizontal-02"));
            var buttons = buttonBar.FindElements(By.TagName("li"));
            buttons[3].Click();


            //visa.Click();

            driver.Quit();
        }

        [Test]
        public void DropDownTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");

            var dropdown = driver.FindElement(By.Id("dropdown"));
            var dropdownSelect = new SelectElement(dropdown);

            var before = dropdownSelect.SelectedOption.Text;

            dropdownSelect.SelectByText("Option 2");

            dropdownSelect.SelectByIndex
            dropdownSelect.SelectByValue

            var after = dropdownSelect.SelectedOption.Text;

            Assert.AreEqual("Option 2", dropdownSelect.SelectedOption.Text);

            driver.Quit();
        }
    }
}
