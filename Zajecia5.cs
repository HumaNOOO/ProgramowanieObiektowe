namespace Zajecia5
{
    class Prostokat
    {
        public Prostokat(float dlug = 5f, float szer = 5f) 
        {
            dlugosc = dlug;
            szerokosc = szer;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia: {0}, Obwod: {1}", powierzchnia(), obwod());
        }

        private float obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        public float powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        private float dlugosc;
        private float szerokosc;
    }

    struct ProstokatStruct
    {
        public ProstokatStruct(float dlug = 0f, float szer = 0f)
        {
            dlugosc = dlug;
            szerokosc = szer;
        }

        private float obwod()
        {
            return 2 * (dlugosc + szerokosc);
        }

        private float powierzchnia()
        {
            return dlugosc * szerokosc;
        }

        public void Prezentuj()
        {
            Console.WriteLine("Obwod: {0}, Powierzchnia: {1}", obwod(), powierzchnia());
        }

        private float dlugosc;
        private float szerokosc;
    }
    class MiernikEnergii
    {
        public MiernikEnergii(float stan)
        {
            stan_poczatkowy = stan;
        }

        public void ustaw_stan(float stan)
        {
            stan_obecny = stan;
        }

        public float pobierz_stan_poczatkowy()
        {
            return stan_poczatkowy;
        }

        public float pobierz_stan_obecny()
        {
            return stan_obecny;
        }

        public float zuzycie()
        {
            return stan_obecny - stan_poczatkowy;
        }

        private float stan_poczatkowy;
        private float stan_obecny;
    }

    class Punkt
    {
        public Punkt(float x1, float y1)
        {
            x = x1;
            y = y1;
        }

        public void Przesun(float dx, float dy)
        {
            x += dx;
            y += dy;
        }

        public float x { get; set; }
        public float y { get; set; }

        public void Wyswietl()
        {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }

    class Odcinek
    {
        public Odcinek(Punkt pkt1, Punkt pkt2)
        {
            p1 = pkt1;
            p2 = pkt2;
        }

        public float dlugosc()
        {
            return MathF.Sqrt(MathF.Pow(p2.x - p1.x, 2) + MathF.Pow(p2.y - p1.y, 2));
        }

        private Punkt p1;
        private Punkt p2;
    }

    class KandydatNaStudia
    {
        public KandydatNaStudia(String nw, float pm, float pi, float pj)
        {
            nazwisko = nw;
            punktyMatematyka = pm;
            punktyInformatyka = pi;
            punktyJezykObcy = pj;
        }

        public float oblicz_punkty()
        {
            return 0.6f * punktyMatematyka + 0.5f * punktyInformatyka + 0.2f * punktyJezykObcy;
        }

        public String pobierz_nazwisko()
        {
            return nazwisko;
        }

        private String nazwisko;
        private float punktyMatematyka;
        private float punktyInformatyka;
        private float punktyJezykObcy;
    }

    class Program
    {
        static void najwieksza_powierzchnia(Prostokat[] p)
        {
            int max_index = 0;
            
            for(int i=0; i<p.Length; i++)
            {
                if (p[i].powierzchnia() > p[max_index].powierzchnia())
                    max_index = i;
            }

            Console.WriteLine("najwieksza powierzchnia: {0}", p[max_index].powierzchnia());
        }
        static void czy_na_prostej(Punkt[] punkty)
        {
            float s1 = (punkty[1].y - punkty[0].y) / (punkty[1].x - punkty[0].x);
            float s2 = (punkty[2].y - punkty[1].y) / (punkty[2].x - punkty[1].x);

            if (s1 == s2)
                Console.WriteLine("Punkty leza na jednej prostej");
            else
                Console.WriteLine("Punkty nie leza na jednej prostej");
        }

        class Prostopadloscian
        {
            public Prostopadloscian(float dlug, float szer, float wys)
            {
                dlugosc = dlug;
                szerokosc = szer;
                wysokosc = wys;
            }

            public float objetosc()
            {
                return dlugosc * szerokosc * wysokosc;
            }

            public void porownaj(Prostopadloscian p)
            {
                if (objetosc() == p.objetosc())
                    Console.WriteLine("Objetosci sa rowne");
                else
                    Console.WriteLine("Objetosci nie sa rowne");
            }

            private float dlugosc;
            private float szerokosc;
            private float wysokosc;
        }
        static void Main(String[] args)
        {
            Prostokat p = new();
            p.Prezentuj();

            Console.WriteLine();

            Prostokat[] prostokaty = { new(3f, 2f), new(10f, 22f), new(8f, 8f) };

            foreach(Prostokat prostokat in prostokaty)
            {
                prostokat.Prezentuj();
            }

            Console.WriteLine();
            najwieksza_powierzchnia(prostokaty);

            Console.WriteLine();
            MiernikEnergii miernik = new(2f);

            miernik.ustaw_stan(10f);

            Console.WriteLine("Stan poczatkowy: {0}, Stan obecny: {1}, Zuzycie energii: {2}", miernik.pobierz_stan_poczatkowy(), miernik.pobierz_stan_obecny(), miernik.zuzycie());

            Console.WriteLine();
            Punkt[] punkty = { new(1, 5), new(2, 10), new(3, 15) };
            czy_na_prostej(punkty);

            Console.WriteLine();
            Odcinek odc = new(new Punkt(2, -10), new Punkt(2, 10));
            Console.WriteLine("Dlugosc odcinka: {0}", odc.dlugosc());

            Console.WriteLine();
            Prostopadloscian prostopadloscian = new(10, 10, 10);
            Prostopadloscian prostopadloscian2 = new(10, 10, 10);
            prostopadloscian.porownaj(prostopadloscian2);

            Console.WriteLine();
            ProstokatStruct ps = new(3, 2);

            ps.Prezentuj();
            Console.WriteLine();

            ProstokatStruct[] prostokatStructs = { ps, new(1, 2), new(5, 8) };

            foreach(ProstokatStruct prstruct in prostokatStructs)
            {
                prstruct.Prezentuj();
            }

            Console.WriteLine();
            KandydatNaStudia[] kandydaci = { new("Kowalski", 50, 63, 77), new("Nowak", 40, 20, 98), new("Spychalski", 90, 90, 90) };

            foreach(KandydatNaStudia kandydat in kandydaci)
            {
                Console.WriteLine("{0}, {1}", kandydat.pobierz_nazwisko(), kandydat.oblicz_punkty());
            }
        }
    }
}
