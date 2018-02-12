using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {        
        [Test]
        public void ContactCreation()
        {            
           
            ContactData contact = new ContactData("555");
            contact.Middlename = "777";
            contact.Lastname = "888";
            contact.Nickname = "888";
            contact.Title = "888";
            contact.Company = "888";
            contact.Address = "888";
            contact.Home = "888";
            contact.Mobile = "888";
            contact.Work = "888";
            contact.Fax = "888";
            contact.Email = "888";
            contact.Email2 = "888";
            contact.Email3 = "888";
            contact.Homepage = "888";
            contact.Address2 = "888";
            contact.Phone2 = "888";
            contact.Notes = "888";

            app.Contacts.CreateContact(contact);
           // app.Navigator.Logout();
        }
        [Test]
        public void EmptyContactCreation()
        {

            ContactData contact = new ContactData("");
            contact.Middlename = "";
            contact.Lastname = "";
            contact.Nickname = "";
            contact.Title = "";
            contact.Company = "";
            contact.Address = "";
            contact.Home = "";
            contact.Mobile = "";
            contact.Work = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";
            contact.Address2 = "";
            contact.Phone2 = "";
            contact.Notes = "";

            app.Contacts.CreateContact(contact);
           // app.Navigator.Logout();
        }
    }
}
