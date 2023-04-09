using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Equals
    {
        public void Integer()
        {
            Console.WriteLine("Enter The First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if(FirstNumber == SecondNumber)
            {
                Console.WriteLine("{0} && {0} Both Number Are Equal" , FirstNumber,SecondNumber);
            }
            else
            {
                Console.WriteLine("The Number Are Not Equal");
            }
        }
    }
}
