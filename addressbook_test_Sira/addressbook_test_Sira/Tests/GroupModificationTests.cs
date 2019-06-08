using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            app.Groups.IsGroupExist();
            GroupData newData = new GroupData("vvv");
            newData.Header = null;
            newData.Footer = null;
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Modify(0, newData);
            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
