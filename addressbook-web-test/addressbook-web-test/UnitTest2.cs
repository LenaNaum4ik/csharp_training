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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            SelectContact(1);
            RemoveContact();
            Logout();
        }                             
    }
}
