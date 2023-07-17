using System;

namespace _2_Exercise
{
    internal class User
    {
        private string name;
        private int age;
        private float height;
        private float width;

        bool InputIsValidText(string nameUser)
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

        public User()
        {
            name = string.Empty;
            age = 0;
            height = 0;
            width = 0;
        }

        public User(string newName, int newAge, float newHeight, float newWidth)
        {
            if (InputIsValidText(newName) && newName != string.Empty)
            {
                name = newName;
            }
            else
            {
                Console.WriteLine("Nome preenchido incorretamente! Por favor, preencher corretamente.");
            }

            if (newAge >= 0)
            {
                age = newAge;
            }
            else
            {
                Console.WriteLine("Idade inválida! Por favor, preencher com número positivo.");
            }

            if (newHeight >= 0)
            {
                height = newHeight;
            }
            else
            {
                Console.WriteLine("Altura inválida! Por favor, preencher com número positivo.");
            }

            if (newWidth >= 0)
            {
                width = newWidth;
            }
            else
            {
                Console.WriteLine("Peso inválido! Por favor, preencher com número positivo.");
            }

        }

        public string GetName()
        {
            return name;
        }


        public void SetName(string value)
        {
            if (InputIsValidText(value) && value != string.Empty)
            {
                name = value;
            }
            else
            {
                Console.WriteLine("Nome preenchido incorretamente! Por favor, preencher corretamente.");
            }
        }

        public int GetAge() 
        {
            return age;
        }
        public void SetAge(int value)
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Idade inválida! Por favor, use número positivo.");
            }
        }

        public float GetHeight()
        {
            return height;
        }
        public void SetHeight(float value)
        {
            if (value >= 0)
            {
                height = value;
            }
            else
            {
                Console.WriteLine("Altura inválida! Por favor, use número positivo.");
            }
        }

        public float GetWidth()
        {
            return width;
        }
        public void SetWidth(float value)
        {
            if (value >= 0)
            {
                width = value;
            }
            else
            {
                Console.WriteLine("Peso inválido! Por favor, use número positivo.");
            }
        }
    }
    
}
