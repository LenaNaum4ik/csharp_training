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
            manager.Navigator.OpenGroupPage();
            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnGroupPage();
            return this;

        }
        public GroupHelper Remove(int p)
        {
            manager.Navigator.OpenGroupPage();
            CheckingGroupExists(p);
            RemoveGroup();
            ReturnGroupPage();
            return this;
            
        }

        private bool TheGroupExists()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public GroupHelper Modify(int p, GroupData newData)
        {
            manager.Navigator.OpenGroupPage();
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnGroupPage();
            return this;
        }

        public GroupHelper SubmitGroupModification()
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
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"),group.Header);
            Type(By.Name("group_footer"), group.Footer);           
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

        public GroupHelper CheckingGroupExists(int index)
        {            
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }

        public GroupHelper CheckingGroupExists(int p, GroupData group)
        {
            if (GroupExists(p))
            {
                if (GroupExists(p))
                {
                    return CheckingGroupExists(p);
                }
                else
                {
                    return CreateGroup(group);
                }
            }
            CheckingGroupExists(p);
            return this;
        }

        public bool GroupExists(int index)
        {
            return IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]"));
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

    }
}
