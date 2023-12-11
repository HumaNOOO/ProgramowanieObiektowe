namespace CwiczeniaLista2
{
    class Osoba
    {
        public String imie;
        public String nazwisko;
        public int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary { get; set; }
        public enum PLEC
        {
            K = 0, M = 1
        }

        public PLEC plec()
        {
            if (imie.Last() == 'a' || imie.Last() == 'A')
            {
                return PLEC.K;
            }
            else
            {
                return PLEC.M;
            }
        }

        public int obliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }
    }
}
