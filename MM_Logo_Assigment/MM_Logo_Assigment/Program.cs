using System;

namespace MM_Logo_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MM_Logo testLogo = new MM_Logo();

            do
            {
                Console.Write("Set letter width: ");
                int letter_Width;

                bool success = int.TryParse(Console.ReadLine(),out letter_Width);

                if (success && letter_Width % 2 != 0)
                {
                    testLogo.letter_Width = letter_Width;
                    testLogo.PrintMM();
                }

                else
                {
                    Console.WriteLine("Use an odd number!");
                }

            } while (true);

        }
    }
}
