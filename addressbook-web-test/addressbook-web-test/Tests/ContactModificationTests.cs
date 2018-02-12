using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData contact = new ContactData("0");
            contact.Middlename = "00";
            contact.Lastname = "00";
            contact.Nickname = "00";
            contact.Title = "00";
            contact.Company = "0";
            contact.Address = "00";
            contact.Home = "0";
            contact.Mobile = "0";
            contact.Work = "0";
            contact.Fax = "0";
            contact.Email = "0";
            contact.Email2 = "0";
            contact.Email3 = "0";
            contact.Homepage = "0";
            contact.Address2 = "0";
            contact.Phone2 = "0";
            contact.Notes = "0";                       

            app.Contacts.Modify(contact);
            app.Navigator.Logout();
        }
    }
}
