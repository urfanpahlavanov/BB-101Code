namespace Urfancode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.2. Book class-ında bir GetInfo deyə bir method-u olsun həmin method book-un bütün məlumatlarını ekrana çıxartsın.
            Book book = new Book("Riyazi analiz", 100, 40, "Kitab", 5, 10);
            book.Getinfo();

            Console.WriteLine(book);

            // 1.3.Book class-ında bir GetDiscountedPrice adlı method olsun salePrice(satış qiyməti) və discountPercent(endirim faizi)-ə görə endirimli qiyməti hesablayıb geriyə qaytarsın.

            Console.WriteLine("Dixcount price= "+book.GetDiscountedPrice());




        }
    }
}