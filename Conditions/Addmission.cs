using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Addmission
    {
        public void Marks()
        {
            Console.WriteLine("Enter Youe Math Marks");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Phy Marks");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Chemistry Marks");
            int C = Convert.ToInt32(Console.ReadLine());
            if (M >= 65 && P >= 55 && C >= 50)
            {
                Console.WriteLine("The Candidate Is Eligible For Addmission");
            }
            else if (M + P + C >= 180)
            {
                Console.WriteLine("The Candidate Is Eligible For Addmission");
            }
            else if (M+P >= 140)
            {
                Console.WriteLine("The Candidate Is Eligible For Addmission");
            }
            else
                Console.WriteLine("The Candidate Is not Eligible For Addmission");
        }
    }
}
