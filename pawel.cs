
class program
{
    static void Main()
    {
        Car car1 = new Car(1999, "marka");
        car1.za();
        Car car2 = new Car(2017, "audi");
        car2.za();
        car1 = car2;
        car1.za();
    }
}

using System;

public class Car
{
    private int rok;
    private string marka;
    public Car(int ro, string mark)
    {
        rok = ro;
        marka = mark;
    }
    public  void za(){
        if (rok <= 1769 || rok > 2017) {
            rok = 0;
        }

        Console.WriteLine("rok {0} marka {1}", rok, marka);
}

}
