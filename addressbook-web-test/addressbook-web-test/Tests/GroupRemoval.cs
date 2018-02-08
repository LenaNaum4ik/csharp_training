using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemoval : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            
            app.Navigator.GoToGroupsPage();
            app.Groups
                .SelectGroup(1)
                .RemoveGroup()
                .ReturnGroupPage();
            app.Navigator.Logout();
        }
    }
}