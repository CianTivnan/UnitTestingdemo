using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateTip(10, "GoOd");
        }

        public static int CalculateTip(double amount, string rating)
        {
            rating = rating.ToLower();

            double tip = 0;

            switch(rating)
            {
                case "terrible":
                    tip = 0;
                    break;
                case "poor":
                    tip = .05;
                    break;
                case "good":
                    tip = .1;
                    break;
                case "great":
                    tip = .15;
                    break;
                case "excellent":
                    tip = .2;
                    break;

                default:
                    tip = -1;
                    break;
            }

            double tipAmount = amount * tip;

            Math.Ceiling(tipAmount);

            tipAmount = (int)(tipAmount);

            return (int)tipAmount;
        }
    }
}
