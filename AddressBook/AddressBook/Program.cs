using System;

namespace AddressBook
{
    class Program
    {
        public List<Contact> personDetails = new List<Contact>();

        public void AddPerson()
        {
            //creating object person from contacts class
            Contact person = new Contact();
            Console.WriteLine("Enter First Name");
            person.firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            person.lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            person.address = Console.ReadLine();
            Console.WriteLine("Enter City");
            person.city = Console.ReadLine();
            Console.WriteLine("Enter state");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            person.zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            person.phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email Id");
            person.email = Console.ReadLine();
            personDetails.Add(person);
        }

        //printing the address book details
        public void Print()
        {
            foreach (Contact person in personDetails)
            {
                Console.WriteLine("Address book details");
                Console.WriteLine("First Name: " + person.firstName);
                Console.WriteLine("Last Name: " + person.lastName);
                Console.WriteLine("Address: " + person.address);
                Console.WriteLine("City: " + person.city);
                Console.WriteLine("State: " + person.state);
                Console.WriteLine("Zip: " + person.zip);
                Console.WriteLine("phone Number: " + person.phoneNumber);
                Console.WriteLine("Email: " + person.email);
            }
        }
        //method for editing contact in address book
        public void Edit()
        {
            if (personDetails.Count != 0)
            {
                Console.WriteLine("Enter contact to modify: ");
                string edit = Console.ReadLine();

                foreach (var person in personDetails)
                {
                    //Tolist() used to return a new list ,means input converted to list
                    if (person.firstName.ToUpper() == edit.ToUpper())
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter the option to modify the property: ");
                            Console.WriteLine("Enter 1 to change First name ");
                            Console.WriteLine("Enter 2 to change Last name ");
                            Console.WriteLine("Enter 3 to change Phone number ");
                            Console.WriteLine("Enter 4 to change Address ");
                            Console.WriteLine("Enter 5 to change City ");
                            Console.WriteLine("Enter 6 to change State ");
                            Console.WriteLine("Enter 7 to change Pincode ");
                            Console.WriteLine("Enter 8 to Exit ");
                            int Option = Convert.ToInt32(Console.ReadLine());

                            switch (Option)
                            {
                                case 1:
                                    Console.WriteLine("Enter the New First Name: ");
                                    person.firstName = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the New Last name: ");
                                    person.lastName = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the New Phone Number: ");
                                    person.phoneNumber = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the New Address: ");
                                    person.address = Console.ReadLine();
                                    break;
                                case 5:
                                    Console.WriteLine("Enter the New City: ");
                                    person.city = Console.ReadLine();
                                    break;
                                case 6:
                                    Console.WriteLine("Enter the New State: ");
                                    person.state = Console.ReadLine();
                                    break;
                                case 7:
                                    Console.WriteLine("Enter the New Pin Code");
                                    person.zip = Console.ReadLine();
                                    break;
                                case 8:
                                    return;
                            }

                        }

                    }
                    else
                    {
                        Console.WriteLine("Enter the valid name..!!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
        //method for deleating or removing a existing contacts
        public void Delete()
        {
            Console.WriteLine("Enter the first name of the peroson you want to remove");
            string delete = Console.ReadLine();

            foreach (var person in personDetails)
            {
                if (person.firstName.ToUpper() == delete.ToUpper())
                {
                    Console.WriteLine("Are you sure you want to delte this contact?(Y/N)");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        personDetails.Remove(person);
                        Console.WriteLine("\nContact is deleted");
                    }
                    else
                    {
                        Console.WriteLine("Contact is not present");
                    }

                }
            }
        }

    }
}