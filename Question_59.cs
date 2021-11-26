using System;

namespace New_folder__7_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 22/8;  // (a)
            Console.WriteLine(n);
            n = 99/8+21/11*7; // (b)
            Console.WriteLine(n);
            double a = 4, b = 3, p = 8, q = 2; // (c)
            double n_ = q/a - p/b;
            Console.WriteLine(n_);
            a = 6; b = 3; p = 8; q = 2; // (d)
            n_ = p/a + q/b;
            Console.WriteLine(n_);
            int a_ = 3, b_ = 2, p_ = 8, q_ = 5; // (e)
            n_ = p_/b_ + q_/a_;
            Console.WriteLine(n_);
            n = 11+7/4+98%6*3; // (f)
            Console.WriteLine(n);
            n = 11/31%8*5-12; // (g)
            Console.WriteLine(n);
            int p__ = 8; int q__ = 5; // (h)
            n = q__*p__+3*p__*p__-(q__%3)*p__*p__*p__;
            Console.WriteLine(n);
            p__ = 5; q__ = 9; // (i)
            n = (q__%2)*p__+6*p__*(q__%3)+(q__%4)*p__*p__*p__;
            Console.WriteLine(n);
            n = 3; a_ = 6; b_ = 2; // (j)
            n *= a_+b_;
            a_--;
            n %= a_;
            Console.WriteLine(n);
            a_ = 0; n = 5; // (k)
            ++n;
            a_ = --n;
            n = n-a_;
            Console.WriteLine(n);
        }
    }
}
