﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

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
            app.Groups.Modify(1, newData);
        }
    }
}