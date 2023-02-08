using System;
namespace AddressBook
{
	public class AddContacts
	{
        public List<CreateContacts> addressList = new List<CreateContacts>();
        public void GetcreateContact()
        {

            CreateContacts contacts = new CreateContacts();

            Console.WriteLine("Enter First Name: ");
            contacts.First_Name = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            contacts.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            contacts.Address = Console.ReadLine();
            Console.WriteLine("Enter City: ");
            contacts.city = Console.ReadLine();
            Console.WriteLine("Enter the State: ");
            contacts.state = Console.ReadLine();
            Console.WriteLine("Enter the zip");
            contacts.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number: ");
            contacts.PhoneNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email Address: ");
            contacts.Email = Console.ReadLine();

            addressList.Add(contacts);
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

            addressList.Add(newcontact);
        }

        public void EditContact()
        {
            Console.WriteLine("Please Enter First Name of Person to Edit");
            string FirstName = Console.ReadLine();

            foreach (CreateContacts contact in addressList)
            {
                if (contact.First_Name == FirstName)
                {
                    Console.WriteLine(" please Enter Details Do You Want To Edit ");
                    Console.WriteLine("Select options to Edit Details :\n" +"1:First_Name"+
                        "2:Last_Name\n" + "3:Address\n" + "4:City\n" +
                        "5:State\n" + " 6:zip Code\n" + "7:Phone Number\n" + "8:Email\n");

                    int option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {

                        case 1:
                            Console.WriteLine("Enter Last Name");
                            contact.First_Name = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter Last Name");
                            contact.Last_Name = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("Enter Address");
                            contact.Address = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("Enter City");
                            contact.city = Console.ReadLine();
                            break;

                        case 5:
                            Console.WriteLine("Enter State");
                            contact.state = Console.ReadLine();
                            break;

                        case 6:
                            Console.WriteLine("Enter Zip Code");
                            contact.zip = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 7:
                            Console.WriteLine("Enter Phone Number");
                            contact.PhoneNo = Convert.ToInt32(Console.ReadLine());
                            break;

                        case 8:
                            Console.WriteLine("Enter Email");
                            contact.Email = Console.ReadLine();
                            break;

                        default:
                            Console.WriteLine("Wrong Option");
                            break;
                    }
                }
                Console.WriteLine("sorry!!! Not Found");
            }
        }

        public void Display()
        {
            foreach (CreateContacts contact in addressList)
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

