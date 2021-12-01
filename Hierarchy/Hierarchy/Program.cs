using System;
namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            Opel opel = new Opel();
            Ford ford = new Ford();

            Console.WriteLine(bmw.FullDataBmw());
            Console.WriteLine(opel.FullDataOpel());
            Console.WriteLine(ford.FullDataFord());
        }
    }
}