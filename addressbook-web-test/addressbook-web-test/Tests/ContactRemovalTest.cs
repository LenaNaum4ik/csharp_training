using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTest : AuthTestBase
    {     

        [Test]
        public void ContactRemoval()
        {
            ContactData contact = new ContactData("555", "666");

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.СhecContacAvailabilityt(0, contact);
            app.Contacts.RemoveContact(0, contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.RemoveAt(0);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }                             
    }
}
