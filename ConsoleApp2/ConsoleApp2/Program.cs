using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   // class Michael


    //    public string name = "Michael";
  //      public string alias = "Wabbafett";
   //     public  int age = 22;








    class Program
    {
        static void Main(string[] args)
        {
            //Preserve current console text color
            ConsoleColor  oldColor = Console.ForegroundColor;

            TellPeopleWhatProgramThisIs();
            TellPeopleWhatProgramThisIs();
            TellPeopleWhatProgramThisIs();

            //This block of code will ask this user for a question
            //and store the question in questionString variable

            Random randomObject = new Random();
            

            while(true)//Loop forever until infinity, which is forever
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ask A Question");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string questionString = Console.ReadLine();

                //If the user types quit, then the code will not run and the user will break out of the loop.
                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                int randomNumber = randomObject.Next(4);

                switch (randomNumber)
                {
                    case 0:
                        {
                            Console.WriteLine("No, and you never will be.");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Yes, as long as you have enough Rupees.");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("RERORERORERORERORERO - (This is the sound you hear when you see a cherry, so the answer is no.");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("So Simply, Very not.");
                            break;
                        }
                

               


                }

               
            }







            //Cleaning up
            Console.ForegroundColor = oldColor;
        }
            
            static void TellPeopleWhatProgramThisIs()
        {
            //Change console text color
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("agic 8 Ball (by: Michael");
        }


    }
}
