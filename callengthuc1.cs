using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_staticlinecomparisionproblem
{
    public class callenghtuc1
    {
        public void check()
        {
            Console.WriteLine("Enter the value of x-cordinate of point1: x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point2: x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point2: y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("Distance between two points: " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ")  is :" + length);
        }
    }
}
