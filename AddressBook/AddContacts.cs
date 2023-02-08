using System;
namespace AddressBook
{
	public class AddContacts
	{
        public List<CreateContacts> addressList = new List<CreateContacts>();
        public List<CreateContacts> addressList1 = new List<CreateContacts>();
        public void GetcreateContact()
        {

            CreateContacts contact = new CreateContacts();
            contact.createContact();

        //    Console.WriteLine("Enter First Name: ");
        //    contacts.First_Name = Console.ReadLine();
        //    Console.WriteLine("Enter Last Name: ");
        //    contacts.Last_Name = Console.ReadLine();
        //    Console.WriteLine("Enter Address: ");
        //    contacts.Address = Console.ReadLine();
        //    Console.WriteLine("Enter City: ");
        //    contacts.city = Console.ReadLine();
        //    Console.WriteLine("Enter the State: ");
        //    contacts.state = Console.ReadLine();
        //    Console.WriteLine("Enter the zip");
        //    contacts.zip = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Phone Number: ");
        //    contacts.PhoneNo = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter Email Address: ");
        //    contacts.Email = Console.ReadLine();
        //    addressList1.Add(contact);
        }

        public void addPerson()
        {
            CreateContacts newcontact = new CreateContacts();

            Console.WriteLine("Enter First Name of Person :");
            newcontact.First_Name = Console.ReadLine();

            foreach (CreateContacts contact in addressList)
            {
                if (contact.First_Name == newcontact.First_Name)
                {
                    Console.WriteLine("Person with this Name Already Exists");
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

            addressList1.Add(newcontact);
        }
        public void Display()
        {
            foreach (CreateContacts contact in addressList1)
            {
                Console.WriteLine("\nFirst Name : " + contact.First_Name);
                Console.WriteLine("\nLast Name : " + contact.Last_Name);
                Console.WriteLine("\nAddress : " + contact.Address);
                Console.WriteLine("\nCity : " + contact.city);
                Console.WriteLine("\nState : " + contact.state);
                Console.WriteLine("\nZip code :  " + contact.zip);
                Console.WriteLine("\nPhone No : " + contact.PhoneNo);
                Console.WriteLine("\nEmail Id : " + contact.Email);
            }
        }
    }
}

