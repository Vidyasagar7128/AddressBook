using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBooks
{
    class DeleteUser
    {
        public Dictionary<String,User> Delete(Dictionary<String,User> dict, String a)
        {

            if (dict.ContainsKey(a))
            {
                dict.Remove(a);
                Console.WriteLine($"Address Deleted Succesfully.! by {a}");
            }
            else
            {
                Console.WriteLine($"{a} Username is Incorrect.!");
            }
            return dict;
        }
    }
}