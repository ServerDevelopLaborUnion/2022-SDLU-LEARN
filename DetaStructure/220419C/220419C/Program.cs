using System;
using System.Threading;
namespace _220419C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            while (y < 10)
                while (x < 10)
                {
                    Console.Clear();
                    Console.SetCursorPosition(x, y);

                    if (x % 3 == 0)
                    {
                        Console.WriteLine(" __@");
                    }
                    else if (x % 3 == 1)
                        Console.WriteLine("_^@");
                    else
                        Console.WriteLine("^_@");
                    Thread.Sleep(500);
                    x++;
                    y++;
                }
        }
    }
}

