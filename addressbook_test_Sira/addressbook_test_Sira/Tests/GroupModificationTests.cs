using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("vvv");
            newData.Header = "fff";
            newData.Footer = "yyy";
            app.Groups.Modify(1, newData);
        }
    }
}
