using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    public class Homepage:DriverHelper
    {

        IWebElement Login_link => Driver.FindElement(By.LinkText("Login"));
        public void click_Login() => Login_link.Click();

        IWebElement logOff => Driver.FindElement(By.LinkText("Log off"));
        public bool isenable() => logOff.Enabled;

    }
}
