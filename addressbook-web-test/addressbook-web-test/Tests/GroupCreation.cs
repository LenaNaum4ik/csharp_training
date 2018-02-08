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
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitNewGroupCreation();
            app.Groups.FillGroupForm(new GroupData("name", "header", "footer"));
            app.Groups.SubmitGroupCreation();
            app.Groups.ReturnGroupPage();
            app.Navigator.Logout();
        }               
    }
}