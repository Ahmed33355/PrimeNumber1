using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter start");

            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter end");

            int end = int.Parse(Console.ReadLine());

            bool prime = true;


            for (int x = start; x < end; x++)
            {
                for (int y = 2; y < x; y++)
                {
                    if (x % y == 0)
                    {

                        prime = false;
                        break;
                    }
                }
                if (prime == true)
                {
                    Console.WriteLine(x);
                }
                else
                {
                    prime = true;
                }
            }
        }
    }
}
            
        
