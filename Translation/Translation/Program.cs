using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation
{
    class Program
    {
        static void Main(string[] args)
        {
            int tx;
            int ty;
            int x;
            int y;
            int x1;
            int y1;
            int x2;
            int y2;
            int x3;
            int y3;
            int x4;
            int y4;
            int result;
            Console.WriteLine("**************************Translation*******************************");
            Console.WriteLine("\n\nEnter The Value of tx :");
            tx = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of ty :");
            ty = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n\nEnter The Value of x1 :");
            x1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y1 :");
            y1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x2 :");
            x2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y2 :");
            y2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x3 :");
            x3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y3 :");
            y3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x4 :");
            x4 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y4 :");
            y4 = Int16.Parse(Console.ReadLine());
            x = tx + x1;
            y = ty + y1;
            Console.WriteLine("\n\nFirst Point is  ("+x+","+y+")");
            x = tx + x2;
            y = ty + y2;
            Console.WriteLine("Second Point is  (" + x + "," + y + ")");
            x = tx + x3;
            y = ty + y3;
            Console.WriteLine("Third Point is  (" + x + "," + y + ")");
            x = tx + x4;
            y = ty + y4;
            Console.WriteLine("Fourth Point is  (" + x + "," + y + ")");
            Console.ReadLine();
        }
    }
}
