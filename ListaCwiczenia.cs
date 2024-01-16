using System.Runtime.CompilerServices;
using System.Windows;
public class Car
{
    private double pojemonoscSilnika;
    private string marka; // nie mam dostepu do polu z powodu private
    static int iloscKol = 4;
    public Car()
    {
        this.pojemonoscSilnika = 0;
        this.marka = " ";
    }
    public Car(double pojemonoscSilnik, string mark)
    {
        this.pojemonoscSilnika = pojemonoscSilnik;
        this.marka = mark;
    }
    public void Car_create()
    {
        Console.WriteLine("{0}  {1}  kon {2}", pojemonoscSilnika, marka, iloscKol);
    }
    ~Car()
    {
        MessageBox.Show("Zwalniam pamiec");
    }
}
class program
{
    public static void Main(String[] args)
    {
        Car p1 = create(1.43, "audi");
        p1.Car_create();
        p1 = null;
    }
    public static Car create(double pojemonoscSilnik, string mark)
    {
        return new Car(pojemonoscSilnik, mark);
    }
}

class program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    int liczba1;
        //    int liczba2=30;
        //    int liczba3=0;
        //    liczba1= liczba2/liczba3;
        //    Console.WriteLine(liczba1);

        //}
        //catch(Exception e)
        //{
        //    Console.WriteLine(e.Message);
        //}
        //finally {
        //    Console.WriteLine("finally");

        //        }
        try
        {
            int[] tab = new int[2];
            tab[25] = 2;
            throw new IndexOutOfRangeException();
        }
        catch
        {
            Console.WriteLine("nie takiej tablicy");
        }
        //catch (IndexOutOfRangeException e) {
        //    Console.WriteLine(e.Message);

        //}
    }
}

class Obliczenia
{
    private int liczba1;
    private int liczba2;
    public Obliczenia(int liczba1, int liczba2)
    {
        this.liczba1 = liczba1;
        this.liczba2 = liczba2;
    }
    public Obliczenia()
    {
        this.liczba1 = 0;
        this.liczba2 = 0;
    }
    private int dodawanie()
    {
        return liczba1+liczba2;
    }
    private int Odejmowanie()
    {
        return liczba1-liczba2;
    }
    private int Mnożenie()
    {
        return liczba1 * liczba2;
    }
    private int Dzielenie()
    {
        try
        {
            return liczba1 / liczba2;
        }
        catch
        {

            return 0;
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
    private double Potęgowanie() {
        return Math.Pow(liczba1, liczba2);
    }
    private double Pierwiastkowanie()
    {
        try
        {
            if( liczba1 < 0)
            {
                throw new Exception();
            }
            double wynik = liczba1;
            for (int i = 1; i < liczba2-1; i++)
            {
                wynik=Math.Sqrt(wynik);

            }
            return wynik;
        }
        catch
        {
            return 0;
        }
        finally
        {
            Console.WriteLine("finally");
        }
    }
    public void pokaz() {
        Console.WriteLine("dodawanie");
        Console.WriteLine(dodawanie());
        Console.WriteLine("Odejmowanie");
        Console.WriteLine(Odejmowanie());
        Console.WriteLine("Mnożenie");
        Console.WriteLine(Mnożenie());
        Console.WriteLine("Dzielenie");
        Console.WriteLine(Dzielenie());
        Console.WriteLine("Potęgowanie");
        Console.WriteLine(Potęgowanie());
        Console.WriteLine("Pierwiastkowanie");
        Console.WriteLine(Pierwiastkowanie());
    }
}
class program
{
    static void Main(string[] args)
    {
        Obliczenia p1 = new Obliczenia(-3,2);
        p1.pokaz();

    }
}
