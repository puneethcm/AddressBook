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
    public List<CreateContacts> addressList = new List<CreateContacts>();
    public static void Main(string[] args)
    {
<<<<<<< HEAD
        Program createContacts = new Program();
        createContacts.GetCreateContacts();
        createContacts.Display();
        Console.ReadLine();
    }
    public void GetCreateContacts()
    {
<<<<<<< HEAD
        Console.WriteLine("Welcome to Address Book system");

        bool value = true;

        while (value)
=======
        Console.WriteLine("!!!Welcome To AddressBook Program!!!!");
        //bool value = true;
        Console.WriteLine("Choose any option below");
        Console.WriteLine("1:Create Contact\n2:Add conctact\n3:Edit contact");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
>>>>>>> UC3-EditContact
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
                //editContact.addPerson();
                editContact.EditContact();
                editContact.Display();
                break;
            default:
                Console.WriteLine("Please choice correct option");
                break;
        }
<<<<<<< HEAD
        Console.ReadLine(); 
=======
        Console.WriteLine("\nWelcome to AddressBook System");
        CreateContacts newcontact = new CreateContacts();

        Console.WriteLine("\nEnter First Name of Person :");
        newcontact.First_Name = Console.ReadLine();

        foreach (CreateContacts contact in addressList)
        {
            if (contact.First_Name == newcontact.First_Name)
            {
                Console.WriteLine("\nPerson with this Name Already Exists");
                return;
            }
        }
        Console.WriteLine("Enter Last Name: ");
        newcontact.Last_Name = Console.ReadLine();

        Console.WriteLine("Enter Address: ");
        newcontact.Address = Console.ReadLine();

        Console.WriteLine("Enter City Name: ");
        newcontact.city = Console.ReadLine();

        Console.WriteLine("Enter State: ");
        newcontact.state = Console.ReadLine();

        Console.WriteLine("Enter Zip Code: ");
        newcontact.zip = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Phone Number: ");
        newcontact.PhoneNo = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter Email-Id");
        newcontact.Email = Console.ReadLine();
    }
    public  void Display()
    {
        foreach(CreateContacts contact in addressList)
        {
            Console.WriteLine("\nFirst Name : " + contact.First_Name);
            Console.WriteLine("\nLast Name : " + contact.Last_Name);
            Console.WriteLine("\nAddress : " + contact.Address);
            Console.WriteLine("\nCity : " + contact.city);
            Console.WriteLine("\nstate : " + contact.state);
            Console.WriteLine("\nZip code :  " + contact.zip);
            Console.WriteLine("\nPhone No : " + contact.PhoneNo);
            Console.WriteLine("\nEmail Id : " + contact.Email);
        }
>>>>>>> UC1-createContact
=======
        Console.ReadLine();
>>>>>>> UC3-EditContact
    }
}