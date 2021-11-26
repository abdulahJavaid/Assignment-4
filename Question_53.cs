using System;

namespace New_folder__4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // (a)
            int x = 20, y = 35;
            x = y++ + x++;
            y = ++y + ++x;
            Console.Write(x);
            Console.Write(y + Environment.NewLine);
            // (b)
            x = 10; y = 15;
            x = x++;
            y = ++y;
            Console.Write(x);
            Console.Write(",");
            Console.Write(y + Environment.NewLine);
            // (c)
            int a = 10;
            a++;
            Console.Write(a + Environment.NewLine);
            // (d)
            int A = 10;
            A++;
            Console.Write(A++ + Environment.NewLine);
            // (e)
            int n = 10;
            int X = n--;
            Console.Write(X + Environment.NewLine);
            // (f)
            int i = 5, j = 6, k = 7, N = 3;
            Console.WriteLine(i+j*k-k%N);
            Console.WriteLine(i/N);
            // (g)
            int l;
            double m = 3.8;
            l = (int)m;
            Console.Write("l = ");
            Console.Write(l + Environment.NewLine);
            // (h)
            int L = 6;
            Console.Write(L);
            L = L + 3;
            Console.Write(L);
            L -= 5;
            Console.Write(L);
            L++;
            Console.Write(L);
        }
    }
}
