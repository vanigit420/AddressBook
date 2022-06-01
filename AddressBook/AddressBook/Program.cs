using System;

namespace AddressBook
{
    class Program
    {
        //creating a new contact
        public List<Contact> person = new List<Contact>();

        public void NewPerson()
        {
            Contact contact = new Contact();

            Console.WriteLine("Enter the FirstName : ");
            contact.firstname = Console.ReadLine();

            Console.WriteLine("Enter the lastName : ");
            contact.lastname = Console.ReadLine();

            Console.WriteLine("Enter the address : ");
            contact.address = Console.ReadLine();

            Console.WriteLine("Enter the city : ");
            contact.city = Console.ReadLine();

            Console.WriteLine("Enter the state : ");
            contact.state = Console.ReadLine();

            Console.WriteLine("Enter the zipcode : ");
            contact.zipcode = Console.ReadLine();

            Console.WriteLine("Enter the email : ");
            contact.email = Console.ReadLine();

            Console.WriteLine("Enter the phoneNumber : ");
            contact.phoneNumber = Console.ReadLine();
            person.Add(contact);
        }

        //details of address book
        public void Print()
        {
            foreach (Contact contact in person)
            {
                Console.WriteLine("Address book details");
                Console.WriteLine("First Name: " + contact.firstname);
                Console.WriteLine("Last Name: " + contact.lastname);
                Console.WriteLine("Address: " + contact.address);
                Console.WriteLine("City: " + contact.city);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("Zip: " + contact.zipcode);
                Console.WriteLine("phone Number: " + contact.phoneNumber);
                Console.WriteLine("Email: " + contact.email);
            }
        }

        //Editing a Contact
        public void Edit()
        {
            if (person.Count != 0)
            {
                Console.WriteLine("Enter the Contact to be Edited");
                string edit = Console.ReadLine();

                foreach (var contact in person)
                {
                    if (contact.firstname == edit)
                    {
                        while (true)
                        {
                            Console.WriteLine("select the Option to Modify : ");
                            Console.WriteLine("Enter 1 to change Firstname ");
                            Console.WriteLine("Enter 2 to change Lastname ");
                            Console.WriteLine("Enter 3 to change Address ");
                            Console.WriteLine("Enter 4 to change City ");
                            Console.WriteLine("Enter 5 to change State ");
                            Console.WriteLine("Enter 6 to change Zipcode ");
                            Console.WriteLine("Enter 7 to change Ph.number ");
                            Console.WriteLine("Enter 8 to change Email ");
                            Console.WriteLine("Enter 9 to Exit ");
                            int Option = int.Parse(Console.ReadLine());

                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the Firstname : ");
                                    contact.firstname = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.WriteLine("Enter the Lastname : ");
                                    contact.lastname = Console.ReadLine();
                                    break;

                                case 3:
                                    Console.WriteLine("Enter the Address : ");
                                    contact.address = Console.ReadLine();
                                    break;

                                case 4:
                                    Console.WriteLine("Enter the City : ");
                                    contact.city = Console.ReadLine();
                                    break;

                                case 6:
                                    Console.WriteLine("Enter the State : ");
                                    contact.state = Console.ReadLine();
                                    break;

                                case 7:
                                    Console.WriteLine("Enter the Zipcode : ");
                                    contact.zipcode = Console.ReadLine();
                                    break;

                                case 8:
                                    Console.WriteLine("Enter the Phone Number : ");
                                    contact.phoneNumber = Console.ReadLine();
                                    break;

                                default:
                                    return;

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter the Valid Name");
                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }

        }

        //Deleting a contact
        public void Delete()
        {
            Console.WriteLine("Enter tne name of the person you want to remove : ");
            string Delete = Console.ReadLine();

            foreach (var contact in person)
            {
                Console.WriteLine("Are you sure you want to delete the contact of this person? (Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    person.Remove(contact);
                    Console.WriteLine("Contact is Deleted");

                }
                else
                {
                    Console.WriteLine("Contact not found");
                }
            }
        }
    }
}