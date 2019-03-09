using PhonebookApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PhonebookApp.Context
{
    public class PhonebookContext : DbContext
    {
        public DbSet<Phonebook> Phonebooks { get; set; }
    }
}