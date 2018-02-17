using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTest : AuthTestBase
    {     

        [Test]
        public void ContactRemoval()
        {
            ContactData contact = new ContactData("555");

            app.Navigator.GoToHomePage();
            app.Contacts.RemoveContact(1, contact);                
            //app.Navigator.Logout();
        }                             
    }
}
