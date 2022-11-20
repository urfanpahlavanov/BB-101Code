namespace urfancode2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Bmw", "F30", 90, 1, 15, "Red", 2018);
            car.Showinfo();

            Console.WriteLine(car);
            Console.WriteLine("Enter distance :");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Remaining fuel=  " + car.Drive(distance));
        }
    }
}