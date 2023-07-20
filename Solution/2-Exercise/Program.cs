using _2_Exercise;

namespace Exercise2
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User();

            Console.WriteLine("Digite o seu nome: ");
            user1.SetName(Console.ReadLine());

            Console.WriteLine("Digite a sua idade: ");
            if (int.TryParse(Console.ReadLine(), out int userAge))
            {
                user1.SetAge(userAge);
            }
            else
            {
                Console.WriteLine("Idade inválida! Por favor, digite um número válido.");
            }


            Console.WriteLine("Digite a sua altura: ");
            float userHeight = float.Parse(Console.ReadLine());
            user1.SetHeight(userHeight);

            Console.WriteLine("Digite o seu peso: ");
            float userWidth = float.Parse(Console.ReadLine());
            user1.SetWidth(userWidth);

            Console.WriteLine($"Nome: {user1.GetName()} {Environment.NewLine}Idade: {user1.GetAge()} {Environment.NewLine}Altura: {user1.GetHeight().ToString("0.00")} {Environment.NewLine}Peso: {user1.GetWidth().ToString("0.00")}");

        }
    }
}
