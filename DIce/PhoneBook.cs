using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DIce
{
    class PhoneBook
    {

        private List<Contact>_contacts = new List<Contact>();
       

        private void Dispalyrecord(Contact contact)
        {
           
            Console.WriteLine($"contactdeails:{contact.Name}{ contact.Number}");

        }
        private void Dispalyrecord(List<Contact> _contacts)
        {
            foreach (var itam in _contacts)
            {
                Console.WriteLine(itam);
            }


        }

        public void Createacontact(Contact contact)
        {
            _contacts.Add(contact);
              
        }
        public void DisplayContact(string number)
        {
            var contact=_contacts.FirstOrDefault(C=>C.Number==number);
            if(contact==null)
            {
                Console.WriteLine("invalid number");
            }
            else
            {
                Dispalyrecord(contact);
            }

        }
        public void DisplayallContact()
        {
           foreach(var contact in _contacts)
            {
                Dispalyrecord(contact);
            }
        }

        public void matchingphrase(string serachph)
        {

            var matchingContact = _contacts.Where(c => c.Name.Contains(serachph)).ToList();

            Dispalyrecord(matchingContact);
        }

    }


}
