using System;

namespace Exercise3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite um texto: ");
            string text = Console.ReadLine();
            Console.WriteLine($"O seu texto possui {text.Length} caracteres.");
        }
    }
}