using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{    class Homeworks
    {
        static void Main(String[] args)
        {
            //Do zadania 2.13
            work2_13();

            //Do zadania 2.12
            work2_12();

            //Do zadania 2.11
            work2_11();

            //Do zadania 2.10
            work2_10(40, 55, 65);

            //Do zadania 2.9
            work2_9();

            //Do zadania 2.8
            work2_8(80, 71, 0);

            //Do zadania 2.7
            work2_7();

            //Do zadania 2.6
            work2_6(140);

            //Do zadania 2.5
            work2_5(21);

            //Do zadania 2.4
            work2_4(2016);

            //Do zadania 2.3
            work2_3(14);

            //Do zadania 2.2
            work2_2(15);

            //Do zadania 2.1
            work2_1(5, 5);

            //Do zadania 1.2
            Console.WriteLine($"{third} {second} {first}");

            //Do zadania 1.3
            work1_3(3, 4);

            //Do zadania 1.5
            work1_5();
        }

        //1.1. Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy.Dane
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

        //1.2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
        //odwrotnej kolejności niż zostały zadeklarowane.

        static char first = 'a';
        static char second = 'b';
        static char third = 'c';
       
        //1.3. Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
        //przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())

        public static void work1_3(double a, double b)
        {
            double diagonal2 = Math.Pow(a, 2) + Math.Pow(b, 2);

            double length = Math.Sqrt(diagonal2);

            Console.WriteLine(length); 
        }

        //1.4. Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
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

        //1.5. Napisz program w którym poprosisz użytkownika o jego dane personalne tj. Imię, nazwisko,
        //numer telefonu, adres email, wzrost, waga(np. 85,7), itp(postaraj się wymyślić jak najwięcej)
        //i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody:
        //typDanych.Parse(odpowiedźOdUżytkownika).
        
        static void work1_5()
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

        //2.1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
        //one równe czy nie.
        //Dane testowe:
        //a : 5
        //b : 5
        //Rezultat w terminalu :
        //5 i 5 są równe

        public static void work2_1(int a, int b)
        {
            if(a ==b)
            {
                Console.WriteLine($"{a} i {b} są sobie równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} są różne");
            }
        }

        //2.2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
        //jest parzysta czy nieparzysta.
        //Dane testowe : 15
        //Rezultat w terminalu :
        //15 jest liczbą nieparzystą

        public static void work2_2(int a)
        {
            if(a % 2 == 0)
            {
                Console.WriteLine($"{a} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{a} jest liczbą nieparzystą");
            }
        }

        //2.3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
        //jest dodatnia czy ujemna.
        //Dane testowe : 14
        //Rezultat w terminalu :
        //14 jest liczbą dodatnią

        public static void work2_3(int a)
        {
            if(a > 0)
            {
                Console.WriteLine($"{a} jest liczbą dodatnią");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} jest liczbą ujemną");
            }
            else
            {
                Console.WriteLine($"{a} jest zerem");
            }
        }

        //4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
        //jest rokiem przestępnym.
        //Dane testowe : 2016
        //Rezultat w terminalu :
        //2016 jest rokiem przestępnym

        public static void work2_4(int a)
        {
            if((a % 4 != 0) || (a % 4 == 0 && a % 400 == 0))
            {
                Console.WriteLine($"{a} nie jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{a} jest rokiem przestępnym");
            }
        }

        //2.5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
        // go do ubiegania się o stanowisko posła, premiera, sentarora,
        //prezydenta.
        //Dane testowe : 21
        //Rezultat w terminalu :
        //Możesz zostać posłem
        //poseł > 21, senator > 30, prezydent 35

        public static void work2_5(int age)
        {
            if(age >= 35)
            {
                Console.WriteLine("Możesz zostać posłem, senatorem lub prezydentem.");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Możesz zostać posłem lub senatorem.");
            }
            else if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem.");
            }
            else
            {
                Console.WriteLine("Jesteś zbyt młody do pełnienia funkcji publicznych.");
            }
        }

        //2.6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
        //wymyśloną kategorię wzrostu.
        //Dane testowe : 140
        //Rezultat w terminalu :
        //Jesteś krasnoludem

        public static void work2_6(int a)
        {
            if (a > 195)
            {
                Console.WriteLine("Jesteś bardzo wysoki");
            }
            else if (a > 180)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else if (a > 165)
            {
                Console.WriteLine("Jesteś średniego wzrostu");
            }
            else if (a > 150)
            {
                Console.WriteLine("Jesteś niewysoki");
            }
            else if (a > 135)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else
            {
                Console.WriteLine("Jesteś niski");
            }
        }

        //2.7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
        //która jest największa
        //Dane testowe:
        //25
        //63
        //79
        //Rezultat w terminalu :
        //79 jest największa z podanych

        public static void work2_7()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            string first = Console.ReadLine();

            Console.WriteLine("Podaj drugą liczbę:");
            string second = Console.ReadLine();

            Console.WriteLine("Podaj trecią liczbę:");
            string third = Console.ReadLine();

            int a = int.Parse(first);
            int b = int.Parse(second);
            int c = int.Parse(third);

            if (a > b)
            {
                if(a > c)
                {
                    Console.WriteLine($"{a} jest największa z podanych");
                }
                else
                {
                    Console.WriteLine($"{c} jest największa z podanych");
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine($"{b} jest największa z podanych");
                }
                else
                {
                    Console.WriteLine($"{c} jest największa z podanych");
                }
            }
        }

        //2.8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
        //na studiach wg.Następujących kryteriów:
        //Wynik z Matury z matematyki powyżej 70
        //Wynik z fizyki powyżej 55
        //Wynik z chemii powyżej 45
        //Łączny wynik z 3 przedmiotów powyżej 180
        //Albo
        //Wynik z matematyki i jednego przedmiotu powyżej 150
        //Dane testowe:
        //Matematyka 80
        //Fizyka 71
        //Chemia 0
        //Rezultat w terminalu :
        //Kandydat dopuszczony do rekrutacji

        public static void work2_8(int math, int physics, int chem)
        {
            if (((math > 70 && physics > 55 && chem > 45) && (math + physics + chem > 180)) || (math + physics > 150 || math + chem > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }
        }

        //2.9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w
        //poniższych kryteriach
        //Temp< 0 – cholernie piździ
        //Temp 0 – 10 – zimno
        //Temp 10 – 20 – chłodno
        //Temp 20 – 30 – w sam raz
        //Temp 30 – 40 – zaczyna być słabo, bo gorąco
        //Temp >= 40 – a weź wyprowadzam się na Alaskę.
        //Dane testowe : 41
        //Rezultat w terminalu :
        //a weź wyprowadzam się na Alaskę.

        public static void work2_9()
        {
            Console.WriteLine("Podaj aktaulną temperaturę:");
            int temp = int.Parse(Console.ReadLine());
            
            if(temp >= 40)
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę");
            }
            else if (temp >= 30)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else if (temp >= 20)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp >= 10)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp >= 0)
            {
                Console.WriteLine("zimno");
            }
            else
            {
                Console.WriteLine("cholernie piździ");
            }
        }

        //2.10. Napisz program, który sprawdzi, czy z 3 podanych długości można
        //stworzyć trójkąt
        //Dane testowe : 40 55 65
        //Rezultat w terminalu :
        //Można zbudować trójkąt

        public static void work2_10(int a, int b, int c)
        {
            if(a + b > c && b + c > a && a + c > b)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkata");
            }
        }

        //2.11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
        //Ocena Opis
        //6 Celujący
        //5 Bardzo dobry
        //4 Dobry
        //3 Dostateczny
        //2 Dopuszczający
        //1 Niedostateczny
        //Dane testowe : 3
        //Rezultat w terminalu :
        //Dostateczny

        public static void work2_11()
        {
            Console.WriteLine("Podaj ocenę w zakresie od 1 do 6");
            int a = int.Parse(Console.ReadLine());

            string rate;

            rate = a switch
            {
                6 => "Celujący",
                5 => "Bardzo dobry",
                4 => "Dobry",
                3 => "Dostateczny",
                2 => "Dopuszczający",
                1 => "Niedostateczny",
                _ => "Wprowadzono błędne dane"
            };

            Console.WriteLine(rate);
        }

        //2.12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
        //nazwę
        //Dane testowe : 4
        //Rezultat w terminalu :
        //Czwartek

        public static void work2_12()
        {
            Console.WriteLine("Podaj dzień tygodnia, 1-7:");
            int a = int.Parse(Console.ReadLine());

            string day;

            day = a switch
            {
                1 => "poniedziałek",
                2 => "wtorek",
                3 => "środa",
                4 => "czwartek",
                5 => "piątek",
                6 => "sobota",
                7 => "niedziela",
                _ => "Wprowadzono błędne dane"
            };

            Console.WriteLine(day);
        }

        //2.13. Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I
        //będzie prostym kalkulatorem
        //Podaj pierwszą liczbę:
        // …
        //Podaj drugą liczbę:
        // …
        //Podaj numer operacji do wykonania:
        //1. Dodawanie
        //2. Odejmowanie
        //3. Mnożenie
        //4. Dzielenie
        //…
        //Twój wynik to:

        public static void work2_13()
        {
            Console.WriteLine("Podaj pierwszą liczbę:");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");

            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

            int action = int.Parse(Console.ReadLine());

            int result;

            result = action switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => a / b
            };

            Console.WriteLine(result);
        }
    }
}
