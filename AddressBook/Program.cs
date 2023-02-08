using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AddressBook;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome To Address Book Program");
        Console.WriteLine("Choose any option below");
        Console.WriteLine("1:Create Contact\n2:Add conctact\n3:Edit contact");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                AddContacts createContact = new AddContacts();
                Console.WriteLine(" ");
                createContact.GetcreateContact();
                createContact.Display();
                break;

            case 2:
                AddContacts addContact = new AddContacts();
                addContact.GetcreateContact();
                Console.WriteLine("Entered Details of Person given as :");
                addContact.addPerson();
                addContact.Display();
                break;

            case 3:
                AddContacts editContact = new AddContacts();
                editContact.GetcreateContact();
                editContact.EditContact();
                editContact.Display();
                break;
            default:
                Console.WriteLine("Please choice correct option");
                break;
        }
        Console.ReadLine();
    }
}