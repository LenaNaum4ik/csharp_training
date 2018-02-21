using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData group = new GroupData("ddd");
            GroupData newData = new GroupData("RRR");
            newData.Header = "ff";
            newData.Footer = "yyyyyy";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.Modify(0, group, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name=newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
