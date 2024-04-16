using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            { 
               ConsoleKey key = Console.ReadKey().Key;
               Console.WriteLine();
               switch (key)
               {
                case ConsoleKey.W:
                    Console.WriteLine("Step forward");
                    break;
                    
                case ConsoleKey.A:
                    Console.WriteLine("Step to the left");
                    break;
                    
                case ConsoleKey.S:
                    Console.WriteLine("Step backward");
                    break;
                    
                case ConsoleKey.D:
                    Console.WriteLine("Step to the right");
                    break;
               }
            }
        }
    }
}
