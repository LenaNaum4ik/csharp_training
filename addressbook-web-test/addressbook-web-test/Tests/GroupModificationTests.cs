using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("RRR");
            newData.Header = "ff";
            newData.Footer = "yyyyyy";

            app.Groups.Modify(1, newData);
           // app.Navigator.Logout();
        }
    }
}
