using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    public class Coordinate
    {
        public void Systeam()
        {
            Console.WriteLine("Find The Quadrant in Which The Co-Ordinate Point Lies");
            Console.WriteLine("Input The Value For X Co-Ordinate");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input The Value For Y Co-Ordinate");
            int Y = Convert.ToInt32(Console.ReadLine());
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("{0} {1} The Co-Ordinate point Lies In First Quandrant" , X ,Y);
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("{0} {1} The Co-Ordinate point Lies In Second Quandrant", X, Y);
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("{0} {1} The Co-Ordinate point Lies In Third Quandrant", X, Y);
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("{0} {1} The Co-Ordinate point Lies In Four Quandrant", X, Y);
            }

        }
    }
}
