using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComprison
{
    
        class Program
    {
        static void Main(string[] args)
        {
            //varibles declaration
            double x1, x2, y1, y2;
            double len, length;
            double point1, point2;

            double x11, x22, y11, y22;
            double len1, length1;
            double point3, point4;

            //taking user inputs for Line 1
            Console.WriteLine("Enter the coordinates of line number 1");
            Console.WriteLine();

            Console.WriteLine("Enter value of x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y2:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            //Taking user inputs for Line 2
            Console.WriteLine();
            Console.WriteLine("Enter the coordinates of line number 2");
            Console.WriteLine();

            Console.WriteLine("Enter value of x1:");
            x11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y1");
            y11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of x2:");
            x22 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of y2:");
            y22 = Convert.ToDouble(Console.ReadLine());

            //using the math class methods to calculate the sqaures and square root as per the formula
            // formula of length = sqrt[(x2 -x1)^2 + (y2-y1)^2]
            point1 = Math.Pow((x2 - x1), 2);
            point2 = Math.Pow((y2 - y1), 2);
            len = point1 + point2;
            length = Math.Sqrt(len);

            point3 = Math.Pow((x22 - x11), 2);
            point4 = Math.Pow((y22 - y11), 2);
            len1 = point3 + point4;
            length1 = Math.Sqrt(len1);

            Console.WriteLine("The length of line 1 : " + length);
            Console.WriteLine("The length of line 2 : " + length1);
            Console.WriteLine();

            if (length == length1)
            {
                Console.WriteLine("Both the lines are equal");
            }
            else
            {
                Console.WriteLine("The lines are not equal");
            }

        }
    }
}

