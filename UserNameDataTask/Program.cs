using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrid 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnime tagurpidi 
            //kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta arv 1, 2 või 3:");
            char userChoice = Convert.ToChar(Console.ReadLine());

            switch (userChoice)
            {
                case '1':
                        Reverse(userName);
                        break;

                case '2':
                        FirstLetter(userName);
                        break;

                case '3':
                        LetterCounter(userName);
                        break;

                default:
                        Console.WriteLine("Kena päeva!");
                        break;
            }

        }
        public static void FirstLetter(string userInput) 
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void Reverse(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void LetterCounter(string userInput)
        {
            Console.WriteLine($"Sinu nimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
