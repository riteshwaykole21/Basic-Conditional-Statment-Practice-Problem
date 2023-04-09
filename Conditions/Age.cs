using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Age
    {
        public void Output()
        {
            Console.WriteLine("Enter Your Currnt Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("Congratulation ! You Are Eliglible For Casting Your Vote");
            }
            else
            {
                Console.WriteLine("Sorry You Are Not Eligible For Casting Vote");
            }
        }

    }
}
