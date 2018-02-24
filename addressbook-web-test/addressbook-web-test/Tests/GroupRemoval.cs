using NUnit.Framework;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemoval : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {        

            GroupData group = new GroupData("ddd");           

            
            app.Groups.СheckGroupExists(0, group);

            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Remove(0);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }       
    }
}