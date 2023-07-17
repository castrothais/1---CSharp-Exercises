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
            int userAge = int.Parse(Console.ReadLine());
            user1.SetAge(userAge);

            Console.WriteLine("Digite a sua altura: ");
            float userHeight = float.Parse(Console.ReadLine());
            user1.SetHeight(userHeight);

            Console.WriteLine("Digite o seu peso: ");
            float userWidth = float.Parse(Console.ReadLine());
            user1.SetWidth(userWidth);

            Console.WriteLine($"Nome: {user1.GetName()}\nIdade: {user1.GetAge()}\nAltura: {user1.GetHeight().ToString("0.00")}\nPeso: {user1.GetWidth().ToString("0.00")}");

        }
    }
}
