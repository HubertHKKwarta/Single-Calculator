using System;
using System.Diagnostics.CodeAnalysis;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadanie 1: Kalkulator operacji matematycznych
            //Cel: Stworzenie prostego kalkulatora obsługującego podstawowe operacje matematyczne.

            //Specyfikacja:
            //Program zapyta użytkownika o dwie liczby.
            //Użytkownik wybierze operację: dodawanie, odejmowanie, mnożenie, dzielenie.
            //Program wyświetli wynik.
            //Obsłuż błędy, np. dzielenie przez 0 lub podanie niepoprawnego wejścia.

            Console.WriteLine("witaj w prostym kalkulatorze!");

            bool runAgain = true; // Flag to control the loop

            while (runAgain)
            {
                double num1 = 0;
                double num2 = 0;

                Console.WriteLine("Wprowadź pierwszą liczbę: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie:");
                }

                Console.WriteLine("Wprowadź drugą liczbę: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie:");
                }

                Console.WriteLine("Podaj co chcesz z nimi zrobić: \n + zeby dodać \n - zeby odjąć \n * zeby pomnożyć \n / zeby podzielić ");
                string chose = Console.ReadLine();

                while (chose != "+" && chose != "-" && chose != "*" && chose != "/")
                {
                    Console.WriteLine("Nie wybrano prawidłowej opcji. Wybierz: +, -, *, /:");
                    chose = Console.ReadLine();
                }

                switch (chose)
                {
                    case "+":
                        Console.WriteLine($"Wynikiem dodawania {num1} i {num2} jest: {num1 + num2}");
                        break;

                    case "-":
                        Console.WriteLine($"Wynikiem odejmowania {num1} i {num2} jest: {num1 - num2}");
                        break;

                    case "*":
                        Console.WriteLine($"Wynikiem mnożenia {num1} i {num2} jest: {num1 * num2}");
                        break;

                    case "/":
                        while (num2 == 0)
                        {
                            Console.WriteLine("Nie można dzielić przez 0! Wprowadź inną liczbę:");
                            while (!double.TryParse(Console.ReadLine(), out num2))
                            {
                                Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie:");
                            }
                        }
                        Console.WriteLine($"Wynik dzielenia {num1} i {num2} to: {num1 / num2}");
                        break;

                    default:
                        Console.WriteLine("Nie wybrano prawidłowej opcji.");
                        break;
                }

                Console.WriteLine("\nCzy chcesz wykonać kolejne obliczenie? (tak/nie):");
                string response = Console.ReadLine().ToLower();
                while (response != "tak" && response != "nie")
                {
                    Console.WriteLine("napisz 'tak' lub 'nie'");
                    response = Console.ReadLine();
                }

                if (response != "tak")
                {
                    runAgain = false;
                    Console.WriteLine("Dziękuję za skorzystanie z programu. Do zobaczenia!");
                }
            }
        }
    }
}