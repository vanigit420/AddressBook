using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class MainBook
    {
        static void Main(String[] args)
        {
            Program name = new Program();

            while (true) ;
            {
                Console.WriteLine("Choose an operation to perform:\n 1- Add a contact \n 2- Edit a existing contact \n 3- View Address book contacts \n 4- Exit from the Addressbook");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        name.NewPerson();
                        Console.WriteLine("Press Any Key to Exit");
                        break;

                    case 2:
                        name.Edit();
                        Console.WriteLine("Press Any Key to Exit");
                        break;

                    case 3:
                        name.Print();
                        Console.WriteLine("Press Any Key to Exit");
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Enter the valid input");
                }

            }
        }
    }
}