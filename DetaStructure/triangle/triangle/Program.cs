using System;

namespace triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제1 길이1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("문재1 길이2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("문제1 길이3");
            int c = int.Parse(Console.ReadLine());
            
            if (c < a + b && b < a + c && a < b + c)
                Console.WriteLine("삼각형 ㄱㄴ");
            else
                Console.WriteLine("삼각형 ㅂㄱㄴ");

            Console.WriteLine("문제2 길이1");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("문제2 길이2");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("문제2 끼인각");
            int A = int.Parse(Console.ReadLine());

            if (A == 60 && d == e)
                Console.Write("정");
            else if (A == 90 && d == e)
                Console.Write("직각이등변");
            else if (A == 90)
                Console.Write("직각 ");
            else if (A > 90)
                Console.Write("둔각 ");
            else
                Console.Write("예각 ");
            
            
            
            Console.WriteLine("삼각형");
        }
    }
}
