using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        private static int turn = 0;

        static void Main(string[] args)
        {
            string name;
            int x = 0;
            int Player1=0;
            int Player2=0;

            Console.WriteLine("Welcome to Dice Game!");
            Console.WriteLine("Please enter your name...");
            name = Console.ReadLine();
            Console.WriteLine("Hi {0},Please take your turn ,{1}",Player1, name);
            Player1 = 1;
            

            if (Player1 == 1)
            {
                Console.WriteLine("you are {0}", Player1);

                for (x = 1; x < 7; x++)
                {
                   
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 2:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 3:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 4:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 5:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 6:
                            Console.WriteLine("You made {0}", x);
                            break;


                    }

                    turn = 0;
                }

                Player2 = 1;

            }
            
            if (Player2 == 1)
            {
               
                for (x = 1; turn < 7; x++)
                {
                    switch (x)
                    {
                        case 1:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 2:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 3:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 4:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 5:
                            Console.WriteLine("You made {0}", x);
                            break;
                        case 6:
                            Console.WriteLine("You made {0}", x);
                            break;



                    }
                    turn = 0;
                }

            }
            Console.WriteLine("Atleast one player must start!");
            Console.ReadLine();





        }







    }
}
