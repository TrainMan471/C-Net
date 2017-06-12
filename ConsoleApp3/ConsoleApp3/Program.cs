using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Empty;
            Console.WriteLine("Enter a String");
            a = Console.ReadLine();

            char[] temp = a.ToCharArray();
            Array.Reverse(temp);
            string b = new string(temp);

            if (a.Equals(b)) 
            {
                Console.WriteLine("palindrome");
            }
            else 
            {
                Console.WriteLine("Not a PalinDrome");
            }
        }
    }
}