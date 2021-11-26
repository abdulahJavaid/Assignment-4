using System;

namespace New_folder__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3, c = 5;
            // (a)
            ++a;
            Console.Write(a);
            Console.Write(b);
            Console.Write(c + Environment.NewLine);
            // (b) -- invalid
            // (c)
            a = 2; b = 3; c = 5;
            a++;
            Console.Write(a);
            Console.Write(b);
            Console.Write(c + Environment.NewLine);
            // (d)
            a = 2; b = 3; c = 5;
            b += a;
            Console.Write(a);
            Console.Write(b);
            Console.Write(c + Environment.NewLine);
            // (e)
            a = 2; b = 3; c = 5;
            b += a*c;
            Console.Write(a);
            Console.Write(b);
            Console.Write(c + Environment.NewLine);
            // (f) -- invalid
            // (g)
            a = 2; b = 3; c = 5;
            a += 2; b = 2/2; c = a*b;
            Console.Write(a);
            Console.Write(b);
            Console.Write(c + Environment.NewLine);
            // (h) -- invalid
            // (i)
            a = 2; b = 3; c = 5;
            b = a++ + b++;
            Console.Write(a);
            Console.Write(b);
            Console.Write(c + Environment.NewLine);
        }
    }
}
