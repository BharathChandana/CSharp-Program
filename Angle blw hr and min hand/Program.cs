using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angle_blw_hr_and_min_hand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time in hour ");
            int hr=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter time in minutes ");
            int min=int.Parse(Console.ReadLine());

            double hrdeg = ((hr %12)*30) + (min * 30 / 60);
            double mindeg = (min * 6);

            double dif=Math.Abs(hrdeg - mindeg);
            if(dif>180)
            {
                dif=360-dif;
            }
            Console.WriteLine($"Angle b/w min and hour hand is {dif}");
        }
    }
}
