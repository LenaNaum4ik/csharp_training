using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreation()
        {
            
            GroupData group = new GroupData("ddd");
            group.Header = "jjj";
            group.Footer = "fff";

            app.Groups.CreateGroup(group);
            app.Navigator.Logout();
        }
        [Test]
        public void EmptyGroupCreation()
        {
            
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

           
            app.Groups.CreateGroup(group);
            app.Navigator.Logout();
        }
    }
}