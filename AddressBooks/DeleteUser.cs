using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{
    class DeleteUser
    {
        public void Delete(Dictionary<String,User> dict, String a)
        {
            Console.WriteLine($"Address Deleted Succesfully.! by {a}");
            Console.WriteLine($"Address Deleted Succesfully.! by {dict.ContainsKey(a)}");
            //Dictionary<String, User> dicts = dict;
            //if (dicts.ContainsKey(a))
            //{
            //    dicts.Remove(a);
            //    Console.WriteLine($"Address Deleted Succesfully.! by {a}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a} Username is Incorrect.!");
            //}
            //return dicts;
        }
    }
}