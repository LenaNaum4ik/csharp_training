using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTest : TestBase
    {     

        [Test]
        public void ContactRemoval()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.SelectContact(1);
            app.Contacts.RemoveContact();
            app.Navigator.Logout();
        }                             
    }
}
