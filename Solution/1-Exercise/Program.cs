using System;

namespace Exercise1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me informe o seu nome:");
            string nameUser = Console.ReadLine();

            if(InputIsValidText(nameUser) && nameUser != string.Empty)
            {
                Console.WriteLine($"Olá, {nameUser}! Seja bem-vindo ao meu repositório do Coding Tank de C#");
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, preencher apenas com texto.");
            }

        }

        static bool InputIsValidText(string nameUser)
        {
            foreach (char c in nameUser)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}