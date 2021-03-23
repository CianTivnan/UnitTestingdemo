using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Divide(10);

        }

        public static bool Divide(int weight)
        {
            if(weight % 2 != 0)
            {
                return false;
            }

            var factors = new List<int>();
            int max = (int)Math.Sqrt(weight);  // Round down

            for (int factor = 1; factor <= max; ++factor) // Test from 1 to the square root, or the int below it, inclusive.
            {
                if (weight % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != weight / factor) // Don't add the square root twice!  Thanks Jon
                        factors.Add(weight / factor);
                }
            }

            var evenFactors = new List<int>();

            foreach (int factor in factors)
            {
                if(factor % 2 == 0)
                {
                    if(factor != weight)
                        evenFactors.Add(factor);
                }
            }

            if(evenFactors.Count >= 2)
            {
                return true;
            }
            if(evenFactors.Count != 0)
            {
                if (weight / evenFactors[0] == 2)
                    return true;

                if (evenFactors[0] * 3 == weight)
                    return true;

                if (evenFactors[0] * 4 == weight)
                    return true;

                if (evenFactors[0] * 5 == weight)
                    return true;

                if (evenFactors[0] * 6 == weight)
                    return true;

                if (evenFactors[0] * 7 == weight)
                    return true;

                if (evenFactors[0] * 8 == weight)
                    return true;

                if (evenFactors[0] * 9 == weight)
                    return true;

                if (evenFactors[0] * 10 == weight)
                    return true;
            }  
            return false;
        }
    }
}
