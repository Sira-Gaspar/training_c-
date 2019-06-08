using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void TestContactCreation()
        {
            ContactData contact = new ContactData("SSS", "QQQ");
            List<ContactData> oldContacts = app.Contacts.GetContactList();
            app.Contacts.Create(contact);
            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
