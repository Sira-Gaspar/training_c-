using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_test_Sira
{
    public class DeleteContactFromGroup : AuthTestBase
    {
        [Test]
        public void TestDeleteContactFromGroup()
        {
            GroupData group = GroupData.GetAllFromDB()[9];
            List<ContactData> oldList = group.GetContact();
            ContactData contact = ContactData.GetAllFromDB().First();
            app.Contacts.IsAddedInGroup(contact, oldList, group);
            //действия
            app.Contacts.DeleteContactFromGroup(contact, group);
            List<ContactData> newList = group.GetContact();
            oldList.Remove(contact);
            oldList.Sort();
            newList.Sort();
            Assert.AreEqual(oldList, newList);
        }

    }
}
