using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Values
    {
        public void Integer()
        {
            Console.WriteLine("Enter Your Height in Centimetter");
            int height = Convert .ToInt32(Console.ReadLine());
            if (height < 150)
            {
                Console.WriteLine("The Person Is Dwarf");
            }
            else if ((height >= 150.0) && (height <= 165.0))
            {
                Console.WriteLine("The Person Is Average Height");
            }
            else if ((height >= 165.0) && (height <= 195.0))
            {
                Console.WriteLine("The Person Is Taller");
            }
            else
            {
                Console.WriteLine("Abnormal Height");
            }

        }
    }
}
