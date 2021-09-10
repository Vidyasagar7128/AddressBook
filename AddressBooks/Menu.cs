using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{
    class Menu
    {
        public Menu()
        {
            showResults();
        }
        public void showResults()
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Create User");
                    CreateUser createUser = new CreateUser();
                    createUser.AddUser();
                    break;
                case 2:
                    Console.WriteLine("Update User");
                    break;
                case 3:
                    Console.WriteLine("Delete User");
                    break;
                case 4:
                    Console.WriteLine("Show User");
                    break;
                default:
                    Console.WriteLine("You choose wrong option");
                    break;
            }
        }
    }
}