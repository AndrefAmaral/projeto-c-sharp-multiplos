using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Digite dois numeros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
