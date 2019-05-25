using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_test_Sira
{
    public class ContactData
    {
        private string first_name;
        private string last_name;
        private string middle_name = "";
                  
        public ContactData(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
        }
        public ContactData(string first_name, string last_name, string middle_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.middle_name = middle_name;
        }
        public string FirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }
       
        public string LastName
        {
            get { return last_name; }
            set { last_name = value; }
        }
    }
}
