using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {        
        [Test]
        public void ContactCreation()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            InitNewCreation();
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
            FillContactForm(contact);
            SubmitContactCreation();
            ReturnContactPage();
            Logout();
        }         
    }
}
