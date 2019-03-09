using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhonebookApp.Models
{
    public class Phonebook
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}