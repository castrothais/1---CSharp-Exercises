using System;

namespace Exercise3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite o valor do Raio: ");
            double radius = double.Parse(Console.ReadLine());
            double area;
            if (radius >= 0 )
            {
                area = (Math.Pow(radius,2) * Math.PI);
                Console.WriteLine($"O raio do círculo é de: {area.ToString("0.00")}");
            } 
            else
            {
                Console.WriteLine($"Raio inválido! Por favor, use número positivo.");
            }
        }
    }
}