using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class LeapYear
    {
        public void Year()
        {
            Console.WriteLine("Enter The Year ");
            int Year = Convert.ToInt32(Console.ReadLine());
            if (Year % 4 == 0)
            {
                Console.WriteLine("Its Leap Year");
            }
            else if (Year % 100 == 0)
            {
                Console.WriteLine("Its Leap Year");
            }
            else if (Year % 400 == 0)
            {
                Console.WriteLine("its Leap Year");
            }
            else
            {
                Console.WriteLine("Its Not A Leap Year");
            }
        }
    }
}
