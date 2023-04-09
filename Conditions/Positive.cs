using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Positive
    {
        public void Negative()
        {
            Console.WriteLine("Enter a Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if(Number > 0)
            {
                Console.WriteLine("its Positive Number");
            }
            else
            {
                Console.WriteLine("its Negative Number");
            }
        }
    }
}
