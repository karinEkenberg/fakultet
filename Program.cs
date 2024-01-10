/*
 Övning 5: Skriv en konsolapplikation för att ange siffror och bestämma summan av siffror från 1
till av det angivna numret och numrets fakultet.


 */
namespace fakultet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Välkommen att räkna ut summan från 1 till talet du anger" +
                    "samt talets fakultet!");
                Console.WriteLine("Ange ett heltal:");
                if (int.TryParse(Console.ReadLine(),out int nummer))
                {
                    int summa = 0;
                    for (int i = 1; i <= nummer; i++)
                    {
                        summa += i;
                    }

                    long fakultet = 1;
                    for (int i = 1; i <= nummer; i++)
                    {
                        fakultet *= i;
                    }
                    Console.WriteLine($"Summan av siffrorna från 1 till {nummer} är: {summa}");
                    Console.WriteLine($"Fakulteten av {nummer} är: {fakultet}");
                    Thread.Sleep(7000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vänligen ange en siffra!");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
                continue;
            }

        }
    }
}
