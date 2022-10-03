using System;
namespace KonwersjaRzutowanieInne
{
    class program
    {
        static void Main(string[] args)
        {
            //RZUTOWANIE ZMIENNYCH

            //int i = int.MaxValue;
            //short s = short.MaxValue;

            //s = (short)i;
            //Console.WriteLine(i);

            //WCZYTYWANIE DANYCH Z KONSOLI

            //string rl = Console.ReadLine();
            //Console.WriteLine(rl);

            //if(Console.ReadKey().Key == ConsoleKey.D1)
            //   Console.WriteLine("Prawda");

            //KONWERSJA TYPÓW STR-INT, INT-STR

            //string s = Console.ReadLine();
            //int i = int.Parse(s) + 2;
            //Console.WriteLine(i);
            //s = i.ToString();
            //Console.WriteLine(s);

            //ŁĄCZENIE TEKSTU I FORMATOWANIE

            string s1 = "Witaj";
            string s2 = "Świecie";
            string s3 = s1 + s2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(s3);
            Console.ReadKey();
            Console.Clear();
        }
    }
}