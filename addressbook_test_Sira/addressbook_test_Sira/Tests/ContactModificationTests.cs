using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_test_Sira
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void TestContactModification()
        {
            app.Contacts.IsContactExist();
            ContactData newData = new ContactData("ppp", null);
            app.Contacts.Modification(2, newData);
        }

    }
}
