using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{

    class CreateUser
    {
        public Dictionary<String, User> cust = new Dictionary<String, User>();
        public User AddUser(Dictionary<String,User> users)
        {
            Console.Write("Enter First Name(Username) : ");
            String fname = Console.ReadLine();
            Console.Write("Enter Last Name : ");
            String lname = Console.ReadLine();
            Console.Write("Enter Address : ");
            String address = Console.ReadLine();
            Console.Write("Enter City : ");
            String city = Console.ReadLine();
            Console.Write("Enter State : ");
            String state = Console.ReadLine();
            Console.Write("Enter ZIP : ");
            long zip = long.Parse(Console.ReadLine());
            Console.Write("Enter Mobile : ");
            long mobile = long.Parse(Console.ReadLine());
            Console.Write("Enter Email : ");
            String email = Console.ReadLine();

            User user = new User()
            {
                firstName = fname,
                lastName = lname,
                address = address,
                city = city,
                state = state,
                zip = zip,
                mobile = mobile,
                email = email
            };
            if (!users.ContainsKey(fname))
            {
                this.cust.Add(user.firstName, user);
                Console.WriteLine();
                Console.WriteLine("Created Succesfully..!");
                Console.WriteLine($"Address Created by {user.firstName} Username");
            }
            else
            {
                throw new ArgumentException($"Already Exist.!");
            }
            return user;
        }
    }
}

//if (!users.ContainsKey(fname))
//{
//    this.cust.Add(user.firstName, user);
//    Console.WriteLine();
//    Console.WriteLine("Created Succesfully..!");
//    Console.WriteLine($"Address Created by {user.firstName} Username");
//}
//else
//{
//    throw new ArgumentException($"Already Exist.!");
//}