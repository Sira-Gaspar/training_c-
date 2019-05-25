﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class ContactCreationTest : TestBase
    {
        [Test]
        public void TestContactCreation()
        {
            ContactData contact = new ContactData("SSS", "QQQ");
            app.Contacts.Create(contact);
            app.Auth.Logout();
        }         
    }
}
