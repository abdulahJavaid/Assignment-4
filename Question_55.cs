using System;

namespace New_folder__5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4;
            ++a;
            a *= b++;  // (a)
            Console.WriteLine(a);
            a = 3; b = 4;
            ++a;
            a *= ++b;  // (b)
            Console.WriteLine(a);
            // (c), ++a *= ++b
            a = 3; b = 4;
            a += 1;
            b += 1;
            a *= b;
            Console.WriteLine(a);
        }
    }
}
