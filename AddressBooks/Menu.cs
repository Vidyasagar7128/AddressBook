using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{
    class Menu
    {
        Dictionary<String, User> cust = new Dictionary<String, User>();
        
        public void ShowResults()
        {
            Console.WriteLine();
            Console.WriteLine("(1). Create Address, (2). Update Address, (3). Delete Address, (4).Details Address");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Create Address : ");
                    CreateUser createUser = new CreateUser();
                    User usr = createUser.AddUser();
                    this.cust.Add(usr.firstName, usr);
                    foreach (KeyValuePair<String, User> i in this.cust)
                    {
                        Console.WriteLine($"Address created by {i.Value.firstName} name");
                    }
                    ShowResults();
                    break;
                case 2:
                    Console.Write("Enter Username for Update Address : ");
                    String u = Console.ReadLine();
                    EditUser editUser = new EditUser();
                    editUser.Edit(this.cust, u);
                    ShowResults();
                    break;
                case 3:
                    Console.Write("Enter Username which you want to Delete : ");
                    String a = Console.ReadLine();
                    DeleteUser deleteUser = new DeleteUser();
                    deleteUser.Delete(this.cust, a);
                    ShowResults();
                    break;
                case 4:
                    Console.WriteLine("User Details : ");
                    ShowUsers showUsers = new ShowUsers();
                    showUsers.show(this.cust);
                    ShowResults();
                    break;
                
                default:
                    Console.WriteLine("You choose wrong option");
                    ShowResults();
                    break;
            }
        }
    }
}