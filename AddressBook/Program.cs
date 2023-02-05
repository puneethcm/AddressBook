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
        Console.WriteLine("Welcome to Address Book system");

        bool value = true;

        while (value)
        {
            Console.WriteLine("\nPlease select the Options :\n" +
                "1)Enter Details & add Contact in List\n" +
                "2)Add new Contact\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddContacts address1 = new AddContacts();
                    //address1.createContact();
                    Console.WriteLine("Entered Details of Person given as :");
                    address1.addPerson();
                    address1.Display();
                    break;
                default:
                    Console.WriteLine("Please choice correct option");
                    break;
            }
            value = false;
            break;
        }
        Console.ReadLine(); 
    }
}