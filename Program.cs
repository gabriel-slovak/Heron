using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---Heron---");
            Console.ResetColor();
            Console.WriteLine();

            Console.WriteLine("Semiperímetro e a área de um triângulo qualquer");
            Console.WriteLine();

            Console.WriteLine("Digite os lados do triângulo desejado!");
            Console.Write("Lado 1...:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Lado 2...:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Lado 3...:");
            Console.ForegroundColor = ConsoleColor.Yellow; 
            double lado3 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            double semiperimetro = (lado1 + lado2 + lado3 ) / 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Semiperímetro = {semiperimetro}");
            Console.ResetColor();

            double area = Math.Sqrt(semiperimetro*(semiperimetro - lado1)*(semiperimetro - lado2)*(semiperimetro - lado3));
            Console.ForegroundColor = ConsoleColor.Yellow;           
            Console.Write($"Área = {area}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
