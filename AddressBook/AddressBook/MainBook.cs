using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class MainBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Address Book");
            //Creating object person1 of program class()
            Program person1 = new Program();

            while (true)
            {
                Console.WriteLine("Choose an operation to perform:\n 1-Add a contact \n 2-Edit a existing contact \n 3-view Address book contacts \n 4-Delete existing contact \n 5-Exit from the Addressbook");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        person1.AddPerson();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 2:
                        person1.Edit();
                        break;
                    case 3:
                        person1.Print();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 4:
                        person1.Delete();
                        Console.WriteLine("Enter any key to exit");
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}