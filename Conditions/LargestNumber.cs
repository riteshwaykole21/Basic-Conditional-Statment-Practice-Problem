using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class LargestNumber
    {
        public void Number()
        {
            Console.WriteLine("Enter First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            int Z = Convert. ToInt32(Console.ReadLine());
            if (X > Y)
            {
                if (X > Z)
                {
                    Console.WriteLine("{0} This Number Is Greatest Among Three", X);
                }
                else
                {
                    Console.WriteLine("{0} This Number Is Greatest Among Three", Y);
                }
            }
            else if (Y > Z)
            {
                Console.WriteLine("{0} This Number Is Greatest Among Three" , Y);
            }
            else
                Console.WriteLine("{0} This Number Is Greatest Among Three Number" , Z);
        }
    }
}
