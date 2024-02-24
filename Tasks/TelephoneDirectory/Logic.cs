using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneDirectory
{
    internal class Logic
    {

        private List<Contact> contacts = new List<Contact>();
        
        public void addContact(string name, int number)
        {
            if (contacts.Contains(new Contact(name, number)))
            {
                Console.WriteLine("Taki kontakt juz istnieje w bazie.");
            }else
            {
                contacts.Add(new Contact(name, number));
            }
        }
        public void FindContactByNumber(int number)
        { Contact contact = contacts.FirstOrDefault(contacts => contacts.PhoneNumber == number);
            if (contact != null)
            {
                Console.WriteLine("To twój Kontakt : " + contact.Name + " " + contact.PhoneNumber);
            }else { Console.WriteLine("Nie ma takiego kontaktu w bazie"); }
           
        }

        public void FindContactByName(string name)
        {
            List<Contact> cont = contacts.Where(contacts => contacts.Name == name).ToList();
            if (cont != null) {
                foreach (Contact contact in cont)
                {
                    Console.WriteLine($"Contact {contact.Name} phone number: {contact.PhoneNumber}");
                } 
            } else { Console.WriteLine("No such contacts"); }
       /*     if (contact != null)
            {
                Console.WriteLine("To twój Kontakt : " + contact.Name + " " + contact.PhoneNumber);
            }
            else { Console.WriteLine("Nie ma takiego kontaktu w bazie"); }
       */
        }

        public void showContacts()
        { int i = 1;
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"{i}. {contact.Name} numer telefonu : {contact.PhoneNumber}");
                i++;
            }
        }
    }
}
