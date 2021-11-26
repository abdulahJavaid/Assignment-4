using System;

namespace New_folder__8_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c = 15, d = 8, e = 40;
            // (a)
            Console.WriteLine((a+b/(c-5))/((d+7)/(e-37)%3));
            // (b)
            Console.WriteLine(a+b/c-5/d+7/e-37%3);
            // (c)
            Console.WriteLine(a*(b*b)-(c*b)+d);
        }
    }
}
