using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void TestContactModification()
        {
            ContactData newData = new ContactData("ppp", null);
            app.Contacts.Modification(2, newData);
        }

    }
}
