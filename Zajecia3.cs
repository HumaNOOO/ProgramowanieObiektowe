namespace Zajecia3
{
    class Program
    {
        static void z1()
        {
            Console.Write("podaj liczbe elementow tablicy: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[n];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("podaj {0} element: ", i + 1);
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("podane elementy: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }
        }

        static void z2()
        {
            int[] ints = { -2, 2, 3 - 4, 5, 6, -7, -9, -1, 0 };
            int[] cints = new int[ints.Length];

            int second_i = 0;

            Console.WriteLine("skopiowane elementy: ");
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > 0)
                {
                    Console.WriteLine(ints[i]);
                    cints[second_i++] = ints[i];
                }
            }
        }

        static void z3()
        {
            Console.Write("podaj liczbe elementow tablicy: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[n];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("podaj {0} element: ", i + 1);
                ints[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max_index = 0;
            int min_index = 0;
            float avg = 0f;
            int positives = 0;

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > ints[max_index]) max_index = i;
                else if (ints[i] < min_index) min_index = i;

                if (ints[i] > 0) positives++;

                avg += ints[i];
            }

            Console.WriteLine("max: {0}, max index: {1}, min: {2}, min index: {3}, srednia wartosci: {4}, liczba wartosci dodatnich: {5}", ints[max_index], max_index, ints[min_index], min_index, avg / ints.Length, positives);
        }

        static bool isPrime(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0) return false;
            }

            return true;
        }
        static void z4()
        {
            int[] ints = new int[100];
            int prime_count = 0;

            Random rand = new();
            Console.WriteLine("liczby pierwsze: ");
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = rand.Next(1, 10000);
                if (isPrime(ints[i]))
                {
                    Console.WriteLine(ints[i]);
                    prime_count++;
                }
            }
            Console.WriteLine("ilosc liczb pierwszych: {0}", prime_count);
        }

        static void z5()
        {
            Console.Write("podaj liczbe elementow tablicy: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ints = new int[n];
            int[] cints = new int[n];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("podaj {0} element: ", i + 1);
                ints[i] = Convert.ToInt32(Console.ReadLine());

                if (i + 1 < ints.Length) cints[i + 1] = ints[i];
                else cints[0] = ints[i];
            }

            Console.Write("tab1: ");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("{0} ", ints[i]);
            }

            Console.Write("\ntab2: ");
            for (int i = 0; i < cints.Length; i++)
            {
                Console.Write("{0} ", cints[i]);
            }
        }

        static void z6()
        {
            float[,] floats = { { 1.2f, 2.3f, 3.4f, 4.8f, 5.7f }, { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f }, { 2.2f, 2.3f, 2.4f, 2.3f, 2.9f }, { 3.1f, 8.2f, 7.3f, 6.4f, 5.5f }, { 0.2f, 1.1f, 0.2f, 2.8f, 3.2f } };
            float trace = 0f;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0}  ", floats[i, j]);
                    if (i == j) trace += floats[i, j];
                }
                Console.WriteLine();
            }
            Console.Write("slad macierzy: {0}", trace);
        }

        static void z7()
        {
            float[,] mat1 = { { 1, 2, 3 }, { 7, 6, 5 } };
            float[,] mat2 = { { 2, 3, 4 }, { 9, 8, 7 } };
            float[,] mat3 = new float[2, 3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mat3[i, j] = mat1[i, j] + mat2[i, j];
                    Console.Write("{0} ", mat3[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void z8()
        {
            String[,] dni = {
                { "poniedziałek", "monday", "montag"},
                {"wtorek","tuesday","dienstag" },
                { "środa","wednesday","mittwoch"},
                {"czwartek","thursday","donnerstag" },
                {"piątek","friday","freitag" },
                {"sobota","saturday","samstag" },
                {"niedziela","sunday","sonntag" }
            };

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0} ", dni[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void z9()
        {
            Console.Write("wpisz zdanie: ");
            String zdanie = Console.ReadLine();

            Console.Write("liczba slow: {0}", zdanie.Split().Length);
        }

        static void z10()
        {
            Console.Write("wpisz date w formacie DD-MM-RRRR: ");
            String data = Console.ReadLine();

            int miesiac = Convert.ToInt32(data.Split('-')[1]);

            switch (miesiac)
            {
                case 1:
                    Console.WriteLine("styczeń");
                    break;
                case 2:
                    Console.WriteLine("luty");
                    break;
                case 3:
                    Console.WriteLine("marzec");
                    break;
                case 4:
                    Console.WriteLine("kwiecień");
                    break;
                case 5:
                    Console.WriteLine("maj");
                    break;
                case 6:
                    Console.WriteLine("czerwiec");
                    break;
                case 7:
                    Console.WriteLine("lipiec");
                    break;
                case 8:
                    Console.WriteLine("sierpień");
                    break;
                case 9:
                    Console.WriteLine("wrzesień");
                    break;
                case 10:
                    Console.WriteLine("październik");
                    break;
                case 11:
                    Console.WriteLine("listopad");
                    break;
                case 12:
                    Console.WriteLine("grudzień");
                    break;
                default:
                    Console.WriteLine("nieprawidłowy numer miesiąca");
                    break;
            }
        }

        static void z11()
        {
            Console.Write("wpisz zdanie: ");

            String zdanie = Console.ReadLine();

            List<char> litery = new();
            List<int> litery_liczba = new();

            for (int i = 0; i < zdanie.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < litery.Count; j++)
                {
                    if (litery[j] == zdanie[i])
                    {
                        litery_liczba[j]++;
                        found = true;
                        break;
                    }
                }

                if (found == false && zdanie[i] != ' ')
                {
                    litery.Add(zdanie[i]);
                    litery_liczba.Add(1);
                }
            }

            for (int i = 0; i < litery.Count; i++)
            {
                Console.WriteLine("{0} - {1}", litery[i], litery_liczba[i]);
            }
        }

        static void z12()
        {
            String tekst = "W parę godzin później, gdy noc zbierała się do odejścia\n" +
"Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
"To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
"co ono oznacza. Byl głodny. Wiqc poszedł do spiżarni,\n" +
"wgramolil się na krzesełko, sięgnąl na górną półkę, ale nic nie znalazł.";

            int znaki = 0;
            int wiersz = 1;
            for (int i = 0; i < tekst.Length; i++)
            {
                if (tekst[i] != '\n') znaki++;
                else
                {
                    Console.WriteLine("liczba znakow w wierszu {0}: {1}", wiersz, znaki);
                    wiersz++;
                    znaki = 0;
                }
            }
        }

        static void z13()
        {
            Console.Write("wpisz zdanie: ");
            String tekst = Console.ReadLine();

            String[] tab = tekst.Split(' ');

            List<String> slowa = new();
            List<int> slowa_liczba = new();

            for (int i = 0; i < tab.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < slowa.Count; j++)
                {
                    if (slowa[j] == tab[i])
                    {
                        found = true;
                        slowa_liczba[j]++;
                    }
                }

                if (!found)
                {
                    slowa.Add(tab[i]);
                    slowa_liczba.Add(1);
                }
            }

            for (int i = 0; i < slowa.Count; i++)
            {
                Console.WriteLine("{0} - {1}", slowa[i], slowa_liczba[i]);
            }
        }

        static void z14()
        {
            String[] ids = { "KOMG-2002","BH-2010","LOL-1929","QWERTY-2020","RES-2021" };

            for(int i=0; i< ids.Length; i++)
            {
                Console.WriteLine("indentyfikator: {0}, lat od zakupu: {1}", ids[i], 2023 - Convert.ToInt32(ids[i].Split('-')[1]));
            }
        }
        static void Main()
        {
            z1();
            z2();
            z3();
            z4();
            z5();
            z6();
            z7();
            z8();
            z9();
            z10();
            z11();
            z12();
            z13();
            z14();
        }
    }
}
