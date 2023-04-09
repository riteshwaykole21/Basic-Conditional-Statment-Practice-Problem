using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class EvenOdd
    {
        public void Even()
        {
            Console.WriteLine("Enter A Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("Its Even Number");
            }
            else
            {
                Console.WriteLine("Its Odd Number");
            }
        }
    }
}
