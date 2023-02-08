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
        Program createContacts = new Program();
        createContacts.GetCreateContacts();
        createContacts.Display();
        Console.ReadLine();
    }
    public void GetCreateContacts()
    {
        Console.WriteLine("\nWelcome to AddressBook System");
        CreateContacts newcontact = new CreateContacts();

        Console.WriteLine("\nEnter First Name of Person :");
        newcontact.First_Name = Console.ReadLine();

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
    }
}