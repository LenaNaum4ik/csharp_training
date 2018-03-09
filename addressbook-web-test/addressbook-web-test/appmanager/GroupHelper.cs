using System;
using System.Collections.Generic;
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

        private List<GroupData> groupCashe= null;

        public List<GroupData> GetGroupList()
        {

            if (groupCashe == null)
            {
                groupCashe = new List<GroupData>();
                manager.Navigator.OpenGroupPage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));
                foreach (IWebElement element in elements)
                {                   
                    groupCashe.Add(new GroupData(element.Text) {
                        Id = element.FindElement(By.TagName("input")).GetAttribute("value")
                    });                  
                }
            }            
            return new List<GroupData>(groupCashe);
        }

        public GroupHelper Remove(int p)
        {           
            RemoveGroup();
            ReturnGroupPage();
            return this;            
        }

        public GroupHelper СheckGroupExists(int index, GroupData group)
        {
            manager.Navigator.OpenGroupPage();
            if (TheGroupExists())
              {                
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();
              }
            else
            {
                CreateGroup(group);
               driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            }
            
           return this;

       }

        private bool TheGroupExists()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public GroupHelper Modify(int p, GroupData newData)
        {
            //manager.Navigator.OpenGroupPage();
            //SelectGroup(p);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnGroupPage();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            groupCashe = null;
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
            groupCashe = null;
            return this;
        }
        public GroupHelper ReturnGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();

            return this;
        }     
              

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            groupCashe = null;
            return this;
        }

    }
}
