using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Classes
{
    public class Contact
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NameContact { get; set; }
        public string EmailContact { get; set; }
        public string PhoneContact { get; set; }
    }  
}
