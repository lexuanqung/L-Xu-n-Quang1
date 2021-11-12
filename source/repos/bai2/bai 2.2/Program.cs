using System;

namespace bai_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 6;
            int str = (int)x / y;
            Console.WriteLine(1.0f*x / y);
            Console.WriteLine(str);
            Console.WriteLine(x % y);
            x++;
            y--;
            Console.WriteLine("x = " + x + ", y = " + y);

        }
    }
}
