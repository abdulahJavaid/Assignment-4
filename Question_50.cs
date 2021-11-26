using System;

namespace myWorkSpace   
{                           
    class mProgram
    {
        static void Main(string[] args)
        {
            // Question no. 50
            // (a)
            float x = 10;
            float y = 11;
            float z = 9;
            Console.WriteLine(x*x+3*x-4);
            // (b)
            Console.WriteLine((x+y)*z);
            // (c)
            Console.WriteLine((x+3*y)/(2*x-y));
            // (d)
            Console.WriteLine(1/(x*x+x+3));
            // (e)
            Console.WriteLine((x+y)/7);
            // (f)
            int b = 1;
            int c = 2;
            Console.WriteLine((2*b)*(c*c*c));
            // (g)
            double a = (3*y)/(5-z);
            Console.WriteLine(a);
            // (h)
            int area = 25;
            double square = Math.Sqrt(area);
            a = area*square;
            Console.WriteLine(a);
            // (i)
            Console.WriteLine((x+32)/(y-32)-(x-2*y));
            // (j)
            float i = 6; float j = 6; float k = 6;
            double res = (3*i*j*k+Math.Pow(k, 9))/(7*i*k-5*Math.Sqrt(j+k)); 
            Console.WriteLine(res);
        }
    }
}
