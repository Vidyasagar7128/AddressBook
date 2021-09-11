using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{
    class EditUser
    {
        public User Edit(Dictionary<String, User> user,String key)
        {
            Console.Write("Update First Name : ");
            String fname = Console.ReadLine();
            Console.Write("Update Last Name : ");
            String lname = Console.ReadLine();
            Console.Write("Update Address : ");
            String address = Console.ReadLine();
            Console.Write("Update City : ");
            String city = Console.ReadLine();
            Console.Write("Update State : ");
            String state = Console.ReadLine();
            Console.Write("Update ZIP : ");
            long zip = long.Parse(Console.ReadLine());
            Console.Write("Update Mobile : ");
            long mobile = long.Parse(Console.ReadLine());
            Console.Write("Update Email : ");
            String email = Console.ReadLine();

            User usr = new User()
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
            if (user.ContainsKey(usr.firstName))
            {
                Console.WriteLine("Already Exist..!");
            }
            else
            {
                user[key] = usr;
                Console.WriteLine();
                Console.WriteLine("Updated Succesfully..!");
                Console.WriteLine($"Hey! {key} your current Username is {usr.firstName}.");
            }
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            foreach (KeyValuePair<String, User> i in user)
            {
                Console.WriteLine($"Updates : {i.Value.firstName},{i.Value.lastName},{i.Value.address},{i.Value.city},{i.Value.state},{i.Value.zip},{i.Value.mobile},{i.Value.email}");
                Console.WriteLine("--------------------------------------------------------------------------------------------------");
            }
            return usr;
        }
    }
}
