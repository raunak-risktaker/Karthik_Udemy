using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore
{
    public  class CustomControl : DriverHelper
    {

        public static void comboBox(string controlName, string value)
        {
            IWebElement ele = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            ele.Clear();
            ele.SendKeys(value);

            Driver.FindElement(By.XPath($"(//ul[@class='o-mnits'])[5]/li[text()='{value}']")).Click();
        }
    }
}
