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
            GroupData toBeRemoved = oldGroups[0];
            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData groups in newGroups)
            {
                Assert.AreNotEqual(groups.Id, toBeRemoved.Id);
            }

        }       
    }
}