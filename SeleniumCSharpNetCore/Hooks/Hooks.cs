using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore.Hooks
{
    public  class Hooks : DriverHelper
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");

            option.AddArguments("--headless");
            new DriverManager().SetUpDriver(new ChromeConfig());
            Driver = new ChromeDriver(@"../../../../SeleniumCSharpNetCore/Driver", option);
        }

        [AfterScenario]
        public void AfterScenario()
        {

        }
    }
}
