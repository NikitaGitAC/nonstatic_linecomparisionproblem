using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_staticlinecomparisionproblem
{
    public class lengthequalornotuc2
    {
        public void check()
        {
            // for first length
            Console.WriteLine("Enter the value of x-cordinate of point1: x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point2: x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point2: y2");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));



            // 2nd length
            Console.WriteLine("Enter the value of x-cordinate of point1: x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point1: y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x-cordinate of point2: x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y-cordinate of point2: y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine2 = Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3)));
            Console.WriteLine("Distance between two points: " + "(" + x1 + "," + y1 + ")" + "(" + x2 + "," + y2 + ")  is :" + lengthOfLine1);
            Console.WriteLine("Distance between two points: " + "(" + x3 + "," + y3 + ")" + "(" + x4 + "," + y4 + ")  is :" + lengthOfLine2);

            // compare the length
            if (lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("Both the line are equal");
            }
            else
            {
                Console.WriteLine("Both lines are not equal");
            }
        }
    }
}
