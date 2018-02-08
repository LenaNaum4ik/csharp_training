﻿using System;
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
            app.Navigator.GoToContactPage();
            app.Contacts.RemoveContact(1);                
            app.Navigator.Logout();
        }                             
    }
}
