using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class GroupModificationTests : GroupTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            app.Groups.IsGroupExist();
            GroupData newData = new GroupData("ytx");
            newData.Header = "hli";
            newData.Footer = "hlfgh";
            List<GroupData> oldGroups = GroupData.GetAllFromDB();
            app.Groups.Modify(oldGroups[6], newData);
            List<GroupData> newGroups = GroupData.GetAllFromDB();
            oldGroups[6].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
