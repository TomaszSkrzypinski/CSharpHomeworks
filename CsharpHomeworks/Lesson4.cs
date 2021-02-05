using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{    class Lesson4
    {
        //1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane
        //które chcesz przetrzymywać to:
        //a.Imię,
        //b.Nazwisko
        //c.Wiek
        //d.Płeć (‘m’ albo ‘k’)
        //e.PESEL
        //f.Numer pracownika (np. 2509324094)
        //Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje

        string name = "Jan";
        string surname = "Kowalski";
        int age = 28;
        char sex = 'm';
        long pesel = 93092134566;
        int id = 123456789;

        //2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
        //odwrotnej kolejności niż zostały zadeklarowane.

        static char first = 'a';
        static char second = 'b';
        static char third = 'c';
        static void Main(String[] args)
        {
            //Do zadania 2
            Console.WriteLine($"{third} {second} {first}");

            //Do zadania 3
            Console.WriteLine(diagonal(3, 4));

            work5();
        }

        //3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
        //przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

        public static double diagonal(double a, double b)
        {
            double diagonal2 = Math.Pow(a, 2) + Math.Pow(b, 2);

            double length = Math.Sqrt(diagonal2);

            return length;
        }

        //4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
        //przypiszesz im następujące wartości:
        //a. 10
        //b.Szkoła Dotneta
        //c. 12,5
        //Pamiętaj o użyciu poprawnych typów danych.

        public static void work4()
        {
            int lCalkowita;
            double lZmiennoprzecinkowa;
            string tekst;

            lCalkowita = 10;
            lZmiennoprzecinkowa = 12.5;
            tekst = "Szkoła Dotneta";
        }

        //5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
        //numer telefonu, adres email, wzrost, waga(np. 85,7), itp(postaraj się wymyślić jak najwięcej)
        //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
        //typDanych.Parse(odpowiedźOdUżytkownika).
        
        static void work5()
        {
            Console.WriteLine("Podaj swoje imię:");
            string name = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko:");
            string surname = Console.ReadLine();
            Console.WriteLine("Podaj swój wzrost:");
            string height = Console.ReadLine();
            Console.WriteLine("Podaj swój wiek:");
            string age = Console.ReadLine();
            Console.WriteLine("Podaj swoją wagę:");
            string weight = Console.ReadLine();

            int.Parse(height);
            int.Parse(age);
            double.Parse(weight);

            Console.WriteLine($"Użytkownik: {name} {surname},\n wzrost: {height},\n wiek: {age},\n waga: {weight}");     
        }
    }
}
