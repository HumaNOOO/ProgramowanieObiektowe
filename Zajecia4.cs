using System.Text;

namespace Zajecia4
{
    class Program
    {
        static float fahrenheitToCelsius(int f)
        {
            return (f - 32) * (5 / 9f);
        }

        static bool between(float x, float a, float b)
        {
            return a < x && x < b;
        }

        static void z2()
        {
            Console.Write("podaj x, a, b: ");
            float x = float.Parse(Console.ReadLine());
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());

            if (between(x, a, b)) Console.WriteLine("liczba {0} jest w przedziale ({1},{2})", x, a, b);
            else Console.WriteLine("liczba {0} nie jest w przedziale ({1},{2})", x, a, b);
        }

        static void Przesun(ref double x, ref double y, double xp, double yp)
        {
            x += xp;
            y += yp;
        }

        static int[] mnozenieA(int[] tab, int mul)
        {
            int[] ret = new int[tab.Length];
            tab.CopyTo(ret, 0);

            for (int i = 0; i < tab.Length; i++)
            {
                ret[i] *= mul;
            }

            return ret;
        }

        static void mnozenieB(ref int[] tab, int mul)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] *= mul;
            }
        }

        static void mnozenieB(ref String[] tab, int mul)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < mul - 1; j++)
                {
                    tab[i] += tab[i];
                }
            }
        }

        static void Rysuj(int a, int b, char znak)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }

        static void wyrazenie(int x, int n)
        {
            int W = 0;

            for (int i = 1; i <= n; i++)
            {
                W += (x + i);
            }

            Console.WriteLine("W: {0}", W);
        }

        static void suma_cyfr(int x)
        {
            String str = Convert.ToString(x);
            int res = 0;

            foreach (char c in str)
            {
                res += c - '0';
            }

            Console.Write(res);
        }

        static Int128 fib(int n)
        {
            Int128 f1 = 1;
            Int128 f2 = 1;
            Int128 res = 1;

            for (int i = 1; i < n; i++)
            {
                res = f1 + f2;
                f1 = f2;
                f2 = res;
            }

            return res;
        }

        static Int128 fib_r(int n)
        {
            return n < 2 ? 1 : fib_r(n - 1) + fib_r(n - 2);
        }

        static int Oblicz(int n)
        {
            return n <= 1 ? 1 : n + Oblicz(n - 1);
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            //z1
            Console.WriteLine(fahrenheitToCelsius(64));

            z2();

            //z3
            double[] wek = { 3, 2 };
            Console.Write("podaj x, y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Przesun(ref x, ref y, wek[0], wek[1]);
            Console.WriteLine("A po przesunieciu: ({0},{1})", x, y);

            //z4
            int[] tb = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] ret = mnozenieA(tb, 2);
            for (int i = 0; i < tb.Length; i++)
            {
                Console.Write("{0}, ", ret[i]);
            }
            Console.WriteLine();
            mnozenieB(ref tb, 3);
            foreach (int elem in tb)
            {
                Console.Write("{0}, ", elem);
            }

            //z5
            Console.WriteLine("podaj dlugosc, szerokosc, znak: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            char znak = Convert.ToChar(Console.ReadLine());
            Rysuj(a, b, znak);
            Console.WriteLine();
            Rysuj(b, a, znak);

            //z6
            String[] tab = { "ala", "kot", "dom" };
            mnozenieB(ref tab, 2);

            foreach (String s in tab)
            {
                Console.Write("\"{0}\" ", s);
            }

            //z7
            wyrazenie(5, 5);

            //z8
            suma_cyfr(125);

            //z9
            Console.WriteLine(fib_r(10));
            Console.WriteLine(fib(10));

            //z10
            Console.WriteLine(Oblicz(5));
        }
    }
}
