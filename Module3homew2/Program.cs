using System;
using System.Text.Json;
using Module3HM2;
using Newtonsoft.Json;

namespace Module3HM2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newcontact = new ContactList<string>();
            var newcontact1 = new ContactList<string>();
            newcontact1.CreateContact(fullname: "John");
            var newcontact2 = new ContactList<string>();
            newcontact2.CreateContact(fullname: "0506634421");
            newcontact.SortByLetterAscending(newcontact1, newcontact2);
        }
    }
}