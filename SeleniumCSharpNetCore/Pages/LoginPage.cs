using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharpNetCore.Pages
{
    class LoginPage : DriverHelper
    {

        IWebElement uname => Driver.FindElement(By.Id("UserName"));
        IWebElement pwd => Driver.FindElement(By.Id("Password"));
        IWebElement click_Submit => Driver.FindElement(By.XPath("//input[@type='submit']"));

        public void EnterUnameAndPwd(string username, string password)
        {
            uname.SendKeys(username);
            pwd.SendKeys(password);
        }

        public void click_Submits() => click_Submit.Click();


    }
}
