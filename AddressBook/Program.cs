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
        Console.WriteLine("\nWelcome to AddressBook System");
        CreateContacts contacts = new CreateContacts()
        {
            First_Name = "Puneeth",
            Middle_Name = "Kumar",
            Last_Name = "C M",
            Address = "Nittuvalli",
            city = "Davangere",
            state = "Karnataka",
            zip = 577004,
            PhoneNo = 8296524711,
            Email = "puneethkumarcm8050@gmail.com"
        };
        Console.WriteLine(contacts.First_Name + "\n" + contacts.Middle_Name + "\n" + contacts.Last_Name + "\n" + contacts.Address + "\n" + contacts.city + "\n"
        + contacts.state + "\n" + contacts.zip + "\n" + contacts.PhoneNo + "\n" + contacts.Email);
        Console.ReadLine();
    }
}