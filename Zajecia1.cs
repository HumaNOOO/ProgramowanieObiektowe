// See https://aka.ms/new-console-template for more information

namespace Zajecia1
{
   class Program
    {
        static void Zadanie2_1()
        {
            Console.Write("Podaj temperature w stopniach Celsjusza: ");
            float celsius = float.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + Convert.ToString(32f + 9f / 5f * celsius));
        }

        static void Zadanie2_2()
        {
            Console.Write("Podaj a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Podaj b: ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Podaj c: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("Delta: " + Convert.ToString(Math.Pow(b, 2) - 4f * a * c));
        }
        
        static void Zadanie2_3()
        {
            Console.Write("Podaj mase ciala w kg: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Podaj wzrost w metrach: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("BMI: " + Convert.ToString(weight / Math.Pow(height, 2)));
        }

        static void Zadanie2_4()
        {
            int x = 100;
            Console.WriteLine(++x * 2); // 202
        }

        static void Zadanie2_5()
        {
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x); // 12
        }

        static void Zadanie2_6()
        {
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x); // 3
        }

        static void Zadanie2_7()
        {
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y); // 7
        }

        static void Zadanie2_8()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine("{0}, {1}, {2}", x, y, z); // True 1 2
        }

        static void Zadanie2_9()
        {
            //a
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            //b
            x = 1; y = 4; z = 2;
            wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            //c
            x = 1; y = 4; z = 2;
            wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            //d
            x = 1; y = 3; z = 4;
            wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            //e
            x = 1; y = 3; z = 4;
            wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            //f
            x = 1; y = 3; z = 4;
            wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }

        static void Zadanie2_10()
        {
            int powierzchnia = 100, osoby = 10;
            double gestosc_zaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine(gestosc_zaludnienia);
        }

        static void Main(String[] args)
        {
            Zadanie2_1();
            Zadanie2_2();
            Zadanie2_3();
            Zadanie2_4();
            Zadanie2_5();
            Zadanie2_6();
            Zadanie2_7();
            Zadanie2_8();
            Zadanie2_9();
            Zadanie2_10();
        }
    }
}
