using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{
    class ShowUsers
    {
        public void show(Dictionary<String,User> user)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------");
            foreach(var i in user)
            {
                Console.WriteLine($" Username : {i.Value.firstName}\n Lastname : {i.Value.lastName}\n Address : {i.Value.address}\n City : {i.Value.city}\n State : {i.Value.state}\n ZIP Code : {i.Value.zip}\n Mobile Number :  {i.Value.mobile}\n Email : {i.Value.email}");
                Console.WriteLine("----------------------------------------------------------------------------------------");
            }
        }
    }
}
