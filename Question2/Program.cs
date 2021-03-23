using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n, x, y;

            n = 10;
            x = 2;
            y = 5;

            IsDivisible(n, x, y);
        }

        static public bool IsDivisible(int n, int x, int y)
        {
            if (((n % x) == 0 && ((n % y) == 0)))
            {
                return true;
            }
            else
                return false;
            
        }
    }
}
