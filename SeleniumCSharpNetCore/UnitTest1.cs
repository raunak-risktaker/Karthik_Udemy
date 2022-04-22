using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {
        public static ChromeOptions options;

        [SetUp]
        public void Setup()
        {
            options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            Driver = new ChromeDriver(@"../../../../SeleniumCSharpNetCore/Driver",options);
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
    }
}