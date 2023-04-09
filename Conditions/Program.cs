using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Check The Equal Or Not");
            Console.WriteLine("Emnter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Equals equals = new Equals();
                    equals.Integer();
                    break;
            }
            Console.ReadLine();
        }
    }
}
