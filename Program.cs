using System;

namespace DB7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ход коня:");
            new Horse(size: 5, startX: 0, startY: 0).Start();

            Console.WriteLine();

            Console.WriteLine("Ферзи:");
            new Elizabet2(8).Start();

        }
    }
}
