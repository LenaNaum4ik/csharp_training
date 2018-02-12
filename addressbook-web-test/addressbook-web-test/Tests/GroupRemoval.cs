using System;
using System.Text;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemoval : AuthTestBase
    {
        [Test]
        public void GroupRemovalTest()
        {           
            app.Navigator.OpenGroupPage();
            app.Groups.Remove(1);             
            
        }
    }
}