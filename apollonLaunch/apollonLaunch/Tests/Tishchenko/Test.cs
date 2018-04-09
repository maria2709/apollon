﻿using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;


namespace apollonLaunch
{
    public class Test
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
        }

        [Test]
        public void CheckWorkPageOnlineCinema()
        {
            MainPage mp = new MainPage();
            Site.CinemaPage cp = new Site.CinemaPage();

            driver.Url = UsefullMethods.OpenTytbySite;
            driver.FindElement(By.XPath(mp.headerResourses)).Click();
            driver.FindElement(By.XPath(mp.resourseCinema)).Click();
            driver.FindElement(By.XPath(cp.TitlePage));
            driver.FindElement(By.XPath(cp.BackToMainPage)).Click();
        }
        [Quit]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
