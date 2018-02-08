﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;
        public NavigationHelper(ApplicationManager manager,string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }             

        public void GoToHomePage()
        {
           driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }
        public void GoToGroupPage()
        {
         driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToContactPage()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
        public void Logout()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
