using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver(@"../../../../SeleniumCSharpNetCore/Driver");
            Driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            try
            {
                Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
                CustomControl.comboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            }
            finally
            {
                Driver.Quit();
            }
        }

        [Test]
        public void LoginTest()
        {
            Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            Homepage homepage = new Homepage();
            LoginPage loginPage = new LoginPage();

            homepage.click_Login();
            loginPage.EnterUnameAndPwd("Raunak", "Raunak123@");
            loginPage.click_Submits();

            Assert.IsTrue(homepage.isenable());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}