using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTest : AuthTestBase
    {
        [Test]
        public void GroupCreation()
        {
            
            GroupData group = new GroupData("ddd");
            group.Header = "jjj";
            group.Footer = "fff";

            List<GroupData> oldGroups = app.Groups.GetGroupList();

            app.Groups.CreateGroup(group);

            List<GroupData> newGroups=app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort(); 
            Assert.AreEqual(oldGroups, newGroups);
          
        }
        [Test]
        public void EmptyGroupCreation()
        {
            
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.CreateGroup(group);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}