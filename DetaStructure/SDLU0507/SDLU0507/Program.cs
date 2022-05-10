using System;

namespace SDLU0507
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a 입력");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b 입력");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("n 입력");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            if (1 <= a && b <= n && n <= 1000000000)
            {
                for (int i = 0; i < n + a; i += a += b)
                {
                    count++;
                }
            }
            Console.WriteLine("출력 : " + count);
        }
    }
}
