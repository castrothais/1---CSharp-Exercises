using System;

namespace Exercise3
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Olá! Digite o valor do Raio: ");
            string radiusInput = Console.ReadLine();

            double radius;
            if (double.TryParse(radiusInput, out radius) && radius >= 0)
            {
                double area = (Math.Pow(radius, 2) * Math.PI);
                Console.WriteLine($"O raio do círculo é de: {area.ToString("0.00")}");
            }
            else
            {
                Console.WriteLine($"Raio inválido! Por favor, use apenas número e que seja positivo.");
            }
        }
    }
}