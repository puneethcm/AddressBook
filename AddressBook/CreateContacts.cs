using System;
namespace AddressBook
{
	public class CreateContacts
	{
        public List<CreateContacts> addressList = new List<CreateContacts>();
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public long PhoneNo { get; set; }
        public string Email { get; set; }


        public void createContact()
        {
            CreateContacts contact = new CreateContacts();

            Console.WriteLine("Enter First Name: ");
            contact.First_Name = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            contact.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            contact.city = Console.ReadLine();
            Console.WriteLine("Enter the State: ");
            contact.state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            contact.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            contact.PhoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Address: ");
            contact.Email = Console.ReadLine();

            addressList.Add(contact);
        }
        public void Display()
        {
            foreach (CreateContacts contact in addressList)
            {
                Console.WriteLine("First Name : " + contact.First_Name);
                Console.WriteLine("Last Name : " + contact.Last_Name);
                Console.WriteLine("Address : " + contact.Address);
                Console.WriteLine("City : " + contact.city);
                Console.WriteLine("state : " + contact.state);
                Console.WriteLine("Zip code :  " + contact.zip);
                Console.WriteLine("Phone No : " + contact.PhoneNo);
                Console.WriteLine("Email Id : " + contact.Email);
            }
        }
    }
    
}

