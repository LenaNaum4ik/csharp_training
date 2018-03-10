using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {       
        public ContactHelper(ApplicationManager manager) : base(manager)
        {            
        }

        internal ContactData GetContactInformationFromTable(int index)
        {
            manager.Navigator.GoToHomePage();
            IList<IWebElement> cells = driver.FindElement(By.Name("entry"))[index];             
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string address = cells[3].Text;
            string allPhones = cells[5].Text;
            return new ContactData(firstName, lastName)
            {
                Address = address,
                AllPhones = allPhones,                      

            };

            throw new NotImplementedException();
        }

        internal ContactData GetContactInformationFromEditForm(int index)
        {
            manager.Navigator.GoToHomePage();
            InitContactModification(0);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string LastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");
            string home = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobile = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string work = driver.FindElement(By.Name("work")).GetAttribute("value");
            string email = driver.FindElement(By.Name("email")).GetAttribute("value");
            string email2 = driver.FindElement(By.Name("email2")).GetAttribute("value");
            string email3 = driver.FindElement(By.Name("email3")).GetAttribute("value");

            return new ContactData(firstName, LastName)
            {
                Address = address,
                Home = home,
                Mobile = mobile,
                Work = work,
                Email = email,
                Email2 = email2,
                Email3 = email3,

            };
        }

        public ContactHelper CreateContact(ContactData contact)
        {
            InitNewCreation();
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnContactPage();
            return this;

        }
        public ContactHelper RemoveContact(int p, ContactData contact)
        {                        
            RemoveContact();
            return this;

        }
        public ContactHelper Modify(int p, ContactData newData)
        {          
            FillContactForm(newData);
            SubmitContactModification();
            ReturnContactPage();
            return this;
        }

        public ContactHelper СheckСhangeableСontact(int index, ContactData contact)
        {
            manager.Navigator.GoToHomePage();
            if (ContacAvailabilityt())
            {
                driver.FindElement(By.XPath($"(//img[@title='Edit'])[" + (index + 1) + "]")).Click();
            }           
            
            else
            {
                CreateContact(contact);
                driver.FindElement(By.XPath($"(//img[@title='Edit'])[" + (index + 1) + "]")).Click();
            }

            return this;
        }

        private List<ContactData> contactCashe = null;

        public List<ContactData> GetContactList()
        {
            if (contactCashe == null)
            {
                contactCashe = new List<ContactData>();
                manager.Navigator.GoToHomePage();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("[name=entry]"));
                foreach (IWebElement element in elements)
                {
                    string lastName = element.FindElement(By.CssSelector("[name=entry] td:nth-of-type(2)")).Text;
                    string firstName = element.FindElement(By.CssSelector("[name=entry] td:nth-of-type(3)")).Text;
                    contactCashe.Add(new ContactData(firstName, lastName));
                }
            }             
            
            return new List<ContactData>(contactCashe);
        }

        public ContactHelper SubmitContactModification()
        {
            //driver.FindElement(By.CssSelector("img[alt=\"Edit\"]")).Click();
            driver.FindElement(By.Name("update")).Click();
            contactCashe = null;
            return this;
        }


        public ContactHelper InitContactModification(int index)
        {
          
           driver.FindElement(By.XPath($"(//img[@title='Edit'])[" + (index + 1) + "]")).Click();
            return this;
        }

        public ContactHelper InitNewCreation()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }
        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.Firstname);
            Type(By.Name("middlename"), contact.Middlename);
            Type(By.Name("lastname"), contact.Lastname);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home);
            Type(By.Name("mobile"), contact.Mobile);
            Type(By.Name("work"), contact.Work);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.Homepage);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Phone2);
            Type(By.Name("notes"), contact.Notes);            
            return this;
        }
        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("(//input[@name='submit'])[2]")).Click();
            contactCashe = null;
            return this;
        }
        public ContactHelper ReturnContactPage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }
        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();
            return this;
        }

        public ContactHelper СhecContacAvailabilityt(int index, ContactData contact)
        {
            manager.Navigator.GoToHomePage();
            if (ContacAvailabilityt())
            {
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();
            }
            else
            {
                CreateContact(contact);
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index + 1) + "]")).Click();
            }

            return this;
        }

        private bool ContacAvailabilityt()
        {
            return IsElementPresent(By.Name("selected[]"));
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            contactCashe = null;
            return this;
        }
    }
}