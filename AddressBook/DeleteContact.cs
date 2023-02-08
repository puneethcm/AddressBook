using System;
using AddressBook;
namespace AddressBook
{
	public class DeleteContact
	{
        AddContacts contactDetails = new AddContacts();

        public void DeleteContacts()
        {
            contactDetails.GetcreateContact();

            Console.WriteLine("\nEnter Contact First Name You Want to Delete");
            string FirstName = Console.ReadLine();

            List<CreateContacts> deleteContact = contactDetails.GetList();

            foreach (CreateContacts contact in deleteContact)
            {
                if (contact.First_Name.ToLower() == FirstName.ToLower())
                {
                    deleteContact.Remove(contact);
                    Console.WriteLine("\nEntered Contact Name {0} is Deleted from the List", FirstName);
                }
            }
            Console.WriteLine("\n{0} Contact not Found", FirstName);
        }
    }
}

