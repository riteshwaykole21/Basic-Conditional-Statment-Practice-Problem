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
            Console.WriteLine("2 : Check Number Even Or Odd");
            Console.WriteLine("3 : Check Number Positive Or Negative");
            Console.WriteLine("4 : Check Year Leap or Not");
            Console.WriteLine("5 : Check To Able For Vote");
            Console.WriteLine("6 : Read The Value Of Integer ");
            Console.WriteLine("Emnter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Equals equals = new Equals();
                    equals.Integer();
                    break;
                case 2:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.Even();
                    break;
                case 3:
                    Positive positive = new Positive();
                    positive.Negative();    
                    break;
                case 4:
                    LeapYear leapYear = new LeapYear();
                    leapYear.Year();
                    break;
                case 5:
                    Age age = new Age();
                    age.Output();
                    break;
                case 6:
                    Values values = new Values();
                    values.Integer();
                    break;
            }
            Console.ReadLine();
        }
    }
}
