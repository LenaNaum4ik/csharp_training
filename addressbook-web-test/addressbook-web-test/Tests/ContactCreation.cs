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
        [Test]
        public void ContactCreation()
        {            
           
            ContactData contact = new ContactData("555", "666");
            

            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.CreateContact(contact);
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
        [Test]
        public void EmptyContactCreation()
        {

            ContactData contact = new ContactData("","");           

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
