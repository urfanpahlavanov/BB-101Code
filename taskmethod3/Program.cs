//Task3.Saheler
namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Area Cricle=" + AreaCircle(6));

            Console.WriteLine("Area Rectangular=" + Aread(6, 12));

            Console.WriteLine("Area =" + Area(3, 4, 5, 2));
        }

            

.          
       
        public static double AreaCircle(double r)
        {
            double p = 3;
            return p * r * r;

        }
        public static double Aread(double a, double b)
        {

            return a * b;

        }
        public static double Area(double x, double y, double z, double radius)
        {
            double p = (x + y + z) / 2;
            return p * radius;

        }
    } }
