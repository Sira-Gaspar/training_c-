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
            app.Groups.Modify(oldGroups[0], newData);
            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupsCount());
            List<GroupData> newGroups = GroupData.GetAllFromDB();
            oldGroups[0].Name = newData.Name;
            oldGroups[0].Header = newData.Header;
            oldGroups[0].Footer = newData.Footer;
            //GroupData.GetAllFromDB()[0].Name = newData.Name;

            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
