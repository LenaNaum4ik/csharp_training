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
            app.Contacts
                .SelectContact(1)
                .RemoveContact();
            app.Navigator.Logout();
        }                             
    }
}
