using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        public static IEnumerable<ContactData> RandomContactDataProvider()
        {
            List<ContactData> contacts = new List<ContactData>();
            for (int i = 0; i < 5; i++)
            {
                contacts.Add(new ContactData(GenerateRandomString(30))
                {
                    FirstName = GenerateRandomString(100),
                    LastName = GenerateRandomString(100),
                    MiddleName = GenerateRandomString(100),
                    NickName = GenerateRandomString(100),
                    Company = GenerateRandomString(100),
                    Tittle = GenerateRandomString(100),
                    Address = GenerateRandomString(100),
                    Home = GenerateRandomString(100),
                    Mobile = GenerateRandomString(100),
                    Work = GenerateRandomString(100),
                    Fax = GenerateRandomString(100),
                    Email = GenerateRandomString(100),
                    Email2 = GenerateRandomString(100),
                    Email3 = GenerateRandomString(100),
                    Homepage = GenerateRandomString(100),
                    Address2 = GenerateRandomString(100),
                    Phone2 = GenerateRandomString(100),
                    Notes = GenerateRandomString(100)
                });
            }
            return contacts;
        }
        [Test, TestCaseSource("RandomGroupProvider")]
        public void ContactCreation(ContactData contact)
        {      
              
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.CreateContact(contact);
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }      
       
    }
}
