using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Conditions
{
    public class Calculation
    {
        public void Marks()
        {
            Console.WriteLine("Enter Your Roll Number");
            int Roll = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("enter Your Phy Marks");
            int Phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your chemistry Marks");
            int Chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Computer Application Marks");
            int com = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Name Of Student : " + Name);
        }
    }
}
