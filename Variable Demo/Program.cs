using System;

namespace Choose_language
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Which language do you want to receive information? 1 - English, 2 - Spanish, 3 - Ukrainian ");
                string line = Console.ReadLine();
                byte languageValue;
                if (!byte.TryParse(line, out languageValue))
                {
                    Console.WriteLine("Please follow the instructions and try again");
                    continue;
                }
                else
                {
                    if (Enum.IsDefined(typeof(Language), languageValue))
                    {
                        Console.WriteLine($"With 2,500 to 3,000 words, you can understand 90% of everyday {(Language)languageValue} conversations,");
                        Console.WriteLine($"{(Language)languageValue} newspaper and magazine articles, and {(Language)languageValue} used in the workplace.");
                        Console.WriteLine($"So it is essential to learn the right {(Language)languageValue} vocabulary words.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please follow the instructions and try again");
                        continue;
                    }
                }
            } while (true);
        }

        public enum Language : byte
        {
            English = 1,
            Spanish = 2,
            Ukrainian = 3
        }
    }
}