using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebAddressbookTests
{
    public class GroupHelper : HelperBase
    {      

        public GroupHelper(ApplicationManager manager) : base(manager)
        {           
        } 

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.Navigator.GoToContactPage();
            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnGroupPage();
            return this;

        }
        public GroupHelper Remove(int p)
        {
            manager.Navigator.GoToContactPage();            
            SelectGroup(p);
            RemoveGroup();
            ReturnGroupPage();
            return this;

        }

        public GroupHelper Modify(int p, GroupData newData)
        {
            manager.Navigator.GoToContactPage();
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupCModification();
            ReturnGroupPage();
            return this;
        }

        public GroupHelper SubmitGroupCModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper InitNewGroupCreation()           
        {
            driver.FindElement(By.Name("new")).Click();
            driver.FindElement(By.Name("group_name")).Clear();
            return this;
        }
        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }
        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }
        public GroupHelper ReturnGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }
        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.Name("selected[]")).Click();
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
    }
}
