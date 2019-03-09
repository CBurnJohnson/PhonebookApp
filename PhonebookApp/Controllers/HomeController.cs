using PhonebookApp.Context;
using PhonebookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhonebookApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(string firstName, string lastName, string phoneNumber)
        {
            using (PhonebookContext db = new PhonebookContext())
            {
                var contact = new Phonebook();
                contact.FirstName = firstName;
                contact.LastName = lastName;
                contact.PhoneNumber = phoneNumber;

                db.Phonebooks.Add(contact);
                db.SaveChanges();

                return RedirectToAction("Phonebook");
            }
        }

        public ActionResult Phonebook()
        {
            using (PhonebookContext db = new PhonebookContext())
            {
                var phonebook = db.Phonebooks;
                var contacts = new List<Phonebook>();
                foreach (var contact in phonebook)
                {
                    var phonebookContact = new Phonebook();
                    phonebookContact.ID = contact.ID;
                    phonebookContact.FirstName = contact.FirstName;
                    phonebookContact.LastName = contact.LastName;
                    phonebookContact.PhoneNumber = contact.PhoneNumber;
                    contacts.Add(phonebookContact);

                }
                return View(contacts);
            }
        }
    }
}