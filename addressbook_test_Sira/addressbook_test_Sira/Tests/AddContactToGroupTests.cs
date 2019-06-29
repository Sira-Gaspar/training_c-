using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_test_Sira
{
    public class AddContactToGroupTests : AuthTestBase
    {
        [Test]
        public void TestAddContactToGroup()
        {
            GroupData group = GroupData.GetAllFromDB()[0];
            List<ContactData> oldList = group.GetContact();
            ContactData contact = ContactData.GetAllFromDB().Except(oldList).First();
            //действия
            app.Contacts.AddContactToGroup(contact, group);

            List<ContactData> newList = group.GetContact();
            oldList.Add(contact);
            oldList.Sort();
            newList.Sort();
            Assert.AreEqual(oldList, newList);
        }
    }
}
