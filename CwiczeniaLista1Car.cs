namespace CwiczeniaLista1
{
    class Program
    {
        static void Main(String[] args)
        {
            //String carName = "Mój samochód";
            //Console.WriteLine(carName);

            //Car car1 = new(2001, "Volkswagen");
            //Console.WriteLine(car1.PobierzRokProdukcji());
            //Console.WriteLine(car1.PobierzMarke());

            //Car car2 = new(2021, "Skoda");
            //Console.WriteLine(car2.PobierzRokProdukcji());
            //Console.WriteLine(car2.PobierzMarke());

            //car1 = car2;
            //Console.WriteLine(car1.PobierzRokProdukcji());
            //Console.WriteLine(car1.PobierzMarke());

            Car car = new(2023, "Ford", "Mustang", 3, 5.0, 8.0);
            Console.WriteLine(car.ObliczKosztPrzejazdu(167.0, 7.15));
        }
    }
}
