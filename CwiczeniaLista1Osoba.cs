namespace CwiczeniaLista2
{
    class Program
    {
        //.14 nie bedzie mozna uzyskac dostepu do pól
        public static void IloscElementowNaleznosc(Koszyk kosz)
        {
            Console.WriteLine("ilość elementów w koszu: {0}, należność: {1} PLN", kosz.IloscElementow(), kosz.Naleznosc());
        }
        public static String DodajPrzedrostek(Osoba os)
        {
            if(os.plec() == Osoba.PLEC.K)
            {
                return "Pani";
            }
            else
            {
                return "PAN";
            }
        }

        public static double BMI(Osoba os)
        {
            return os.waga / (Math.Pow(os.wzrost / 100f, 2));
        }

        public static void WyswietlZespolona(Zespolone z)
        {
            if (z.b >= 0)
            {
                Console.Write("{0}+{1}i\n", z.a, z.b);
            }
            else
            {
                Console.Write("{0}{1}i\n", z.a, z.b);
            }
        }

        static void Main(String[] args)
        {
            Osoba dyrektor = new()
            {
                imie = "Alina",
                nazwisko = "Kowalska",
                rokUrodzenia = 1990
            };

            Console.WriteLine("wiek: {0}", dyrektor.obliczWiek());

            Console.WriteLine("Dyrektorem jest {0} {1} {2}", DodajPrzedrostek(dyrektor), dyrektor.imie, dyrektor.nazwisko);

            Osoba pacjent = new()
            {
                imie = "Jan",
                nazwisko = "Kowalski",
                wzrost = 193,
                waga = 68
            };

            double bmi = BMI(pacjent);
            Console.WriteLine("BMI: {0}", bmi);

            if (bmi < 16)
            {
                Console.WriteLine("wygłodzenie");
            }
            else if (bmi >= 16 && bmi < 16.9)
            {
                Console.WriteLine("wychudzenie");
            }
            else if (bmi >= 17 && bmi < 18.5)
            {
                Console.WriteLine("niedowaga");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("waga prawidłowa");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("nadwaga");
            }
            else if (bmi >= 30 && bmi < 34.9)
            {
                Console.WriteLine("otyłość I stopnia");
            }
            else if (bmi >= 35 && bmi < 39.9)
            {
                Console.WriteLine("otyłość II stopnia");
            }
            else
            {
                Console.WriteLine("otyłość III stopnia");
            }

            //zakupy
            Koszyk k = new();
            k.DodajProdukt(new("Monster",5.99));
            k.DodajProdukt(new("Cola",7.95));
            k.DodajProdukt(new("Chipsy", 4.65));
            IloscElementowNaleznosc(k);

            Zespolone z1 = new(5,5);
            Zespolone z2 = new(4,2);
            Zespolone z3 = new(1, 1);

            WyswietlZespolona(z1.Pomnoz(z2));
            WyswietlZespolona(z1.Dodaj(z2));
            WyswietlZespolona(z1.Odejmij(z2));
            WyswietlZespolona(z1.Podziel(z2));
        }
    }
}
