using System;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace W2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            Task13();
        }

        public static void Task1()
        {
            int a;
            int b;

            Console.WriteLine("Podaj pierwsza liczbe calkowitą: ");
            Int32.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Podaj drugą liczbe całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out b);


            //Pierwsza metoda sprawdzenia
            if (a == b)
            {
                Console.WriteLine("Podane liczby są równe!");
            } else
            {
                Console.WriteLine("Podane Liczby nie są równe");
            }

            //Alternatywna metoda sprawdzenia
            string message= a == b ? "Podane liczby są równe" : "Podane liczby nie są równe";
            Console.WriteLine(message);
        }

        public static void Task2()
        {
            int number;

            Console.WriteLine("Podaj liczbę całkowitą:");
            Int32.TryParse(Console.ReadLine(), out number);

            string message = number % 2 == 0 ? "Podana liczba jest parzysta" : "Podana liczba jest nieparzysta";
            Console.WriteLine(message);
        }

        public static void Task3()
        {
            int number;

            Console.WriteLine("Podaj liczbe:");
            Int32.TryParse(Console.ReadLine(), out number);

            string message;

            if (number > 0)
            {
                message = "Podana liczba jest dodatnia";
            } else if (number <0)
            {
                message = "Podana liczba jest ujemna";
            } else
            {
                message = "Podana liczba jest zerem";
            }
            Console.WriteLine(message);
        }

        public static void Task4()
        {
            int year;

            Console.WriteLine("Podaj rok");

            Int32.TryParse(Console.ReadLine(), out year);

            //rok jest przestepny jeśli  jest podzielny przez 4 i nie jest 
            //podzielny przez 100 lub jest podzielny przez 400.
            string message = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 ? "Rok jest przestępny" : "Rok nie jest przestępny";
            Console.WriteLine(message);
        }

        public static void Task5()
        {
            byte age;

            Console.WriteLine("Podaj ile masz lat a powiem Ci kim możesz być:");
            Byte.TryParse(Console.ReadLine(), out age);

            string message="Nikim nie możesz być";

            //wiek do sejmu to 21 lat do senatu 30 a prezydenta 35
            if (age >= 35)
            {
                message = "Możesz zostać nawet Prezydentem";
            } else if (age >= 30)
            {
                message="Możesz zostać senatorem";
            } else if (age >= 21)
            {
                message="Możesz zostać posłem";
            }

            Console.WriteLine(message);


        }

        public static void Task6()
        {
            byte height;

            Console.WriteLine("Podaj wzrost od 0-255[cm]");
            Byte.TryParse(Console.ReadLine(), out height);

            string message="Jesteś ";

            if (height >= 230)
            {
                message+="gigantem";
            } else if (height>=200)
            {
                message += "elfem";
            } else if (height >= 150)
            {
                message+= "człowieniem";
            } else
            {
                message += "krasnoludem";
            }

            Console.WriteLine(message);
        }

        public static void Task7()
        {
            Console.WriteLine("Podaj trz liczby oddzielone enterem:");
            int a;
            Int32.TryParse(Console.ReadLine(), out a);
            int b;
            Int32.TryParse(Console.ReadLine(), out b);
            int c;
            Int32.TryParse(Console.ReadLine(), out c);

            int biggestNumber;
            if(a>b && a > c)
            {
                biggestNumber = a;
            } else if (b>a && b > c)
            {
                biggestNumber = b;
            } else
            {
                biggestNumber = c;
            }

            Console.WriteLine($"Najwieksza podana liczba to: {biggestNumber}");
        }

        public static void Task8()
        {
            Console.WriteLine("Podaj wynik z matematyki:");
            byte math;
            Byte.TryParse(Console.ReadLine(), out math);
            Console.WriteLine("Podaj wynik z fizyki:");
            byte physics;
            Byte.TryParse(Console.ReadLine(), out physics);
            Console.WriteLine("Podaj wynik z chemi");
            byte chemistry;
            Byte.TryParse(Console.ReadLine(), out chemistry);

            ushort sumOfPoints = (ushort) ( math + chemistry + physics);

            Console.WriteLine($"Suma punktów ze wszystkich przedmiotów to {sumOfPoints}");

            string message;
            if((math >70 && physics>55 && chemistry>45 && sumOfPoints>180) || ((math+physics>150) || (math + chemistry > 150)))
            {
                message="Kandydat dopuszczony do rekrutacji";
            } else
            {
                message = "Kandydat niedopuszczony do rekrutacji";
            }

            Console.WriteLine(message);
        }

        public static void Task9()
        {
            float temperature;

            Console.WriteLine("Podaj temperature w stopniach Celsjusza");
            float.TryParse(Console.ReadLine(), out temperature);

            string message;
            if (temperature >= 40)
            {
                message = "Strasznie ciepło";
            } else if (temperature >= 30)
            {
                message = "zaczyna być ciepło";
            } else if (temperature >= 20)
            {
                message = "w sam raz";
            } else if (temperature >= 10)
            {
                message = "chłodno";
            } else if (temperature >= 0)
            {
                message = "zimno";
            } else
            {
                message = "pizga złem";
            }

            Console.WriteLine(message);
        }

        public static void Task10()
        {
            Console.WriteLine("Podaj dlugości 3 boków trójkąta oddzielone enterem");
            uint a;
            UInt32.TryParse(Console.ReadLine(), out a);
            uint b;
            UInt32.TryParse(Console.ReadLine(), out b);
            uint c;
            UInt32.TryParse(Console.ReadLine(), out c);

            uint longestArm;
            uint sumOfShortArms;

            //znajduje najdluzsze ramie i sume krotszych ramion
            if (a > b && a > c)
            {
                longestArm = a;
                sumOfShortArms = b + c;

            } else if (b>a && b > c)
            {
                longestArm = b;
                sumOfShortArms = c + a;
            } else
            {
                longestArm = c;
                sumOfShortArms = a + b;
            }

            //trojkat mozna zbudowac jesli najdluzsze ramie jest krotsze od sumy dlugosci pozostalych ramion

            if(longestArm<sumOfShortArms)
            {
                Console.WriteLine("Można zbudować trójkąt");
            } else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }
        }

        public static void Task11()
        {
            Console.WriteLine("Podaj ocene ucznia:");
            string grade = Console.ReadLine();

            string message = grade switch
            {
                "1" => "Niedostateczny",
                "2" => "Dopuszczający",
                "3" => "Dostateczny",
                "4" =>"Dobry",
                "5" =>"Bardzo dobry",
                "6" =>"Celujący",
                _ =>"Nie ma takiej oceny",
            };

            Console.WriteLine(message);
        }

        public static void Task12()
        {
            Console.WriteLine("Podaj numer dnia tygodnia:");
            string day = Console.ReadLine();

            string message = day switch
            {
                "1" => "Poniedziałek",
                "2" => "Wtorek",
                "3" => "Środa",
                "4" => "Czwartek",
                "5" => "Piątek",
                "6" => "Sobota",
                "7" => "Niedziela",
                _ => "Nie ma takiego dnia",
            };

            Console.WriteLine(message);
        }

        public static void Task13()
        {
            Console.WriteLine("Podaj pierwszą liczbe:");
            float a;
            float.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Podaj druga liczbe:");
            float b;
            float.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie (+)");
            Console.WriteLine("2. Odejmowanie (-)");
            Console.WriteLine("3. Mnożenie (*)");
            Console.WriteLine("4. Dzielenie (/)");

            string input = Console.ReadLine();
            string message;
            
            switch (input)
            {
                case "1":
                    message = (a + b).ToString();
                    break;
                case "2":
                    message = (a - b).ToString();
                    break;
                case "3":
                    message = (a * b).ToString();
                    break;
                case "4":
                    if (b != 0)
                    {
                        message = (a / b).ToString();
                    } else
                    {
                        message = "Nie można dzielić przez 0";
                    }
                    break;
                default:
                    message = "Nie ma takiej opcji niestety :( ";
                    break;
            };

            Console.WriteLine($"Wynik: {message}");
        }
    }

    
}
