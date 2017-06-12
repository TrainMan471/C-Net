using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace - I like the green color
namespace SubwayChickens
{

    class Program
    {    //Entry Point
        static void Main(string[] args)
        {
            

            //Starting point of everything
            Console.WriteLine("Type a number, any number");
            ConsoleKeyInfo keyinfo = Console.ReadKey();

            PrintFooToTheScreen100Times();//Call the function PrintFooToTheScreen100Times

            if (keyinfo.KeyChar == 'a')
            {
                Console.WriteLine("That is not a number you are a communist");
            }
            else
            {


                   Console.WriteLine("Did you type {0} ", keyinfo.KeyChar.ToString());
            }
        }       static void PrintFoo()
            {
            Console.WriteLine("Foo");
        }

              static void PrintFooToTheScreen100Times()
        {
           for (int counter = 0; counter <= 100; counter++ )//Counter to call function PrintFoo one hundred times
            {
                PrintFoo();//Call function PrintFoo()
            }
        }
    }
}
