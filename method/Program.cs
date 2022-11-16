namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task2 
                Console.WriteLine("enter the word ");

                string word = Console.ReadLine();

                Console.WriteLine("enter count ");

                int count = int.Parse(Console.ReadLine());

                Repeat(word, count);



         }
            public static void Repeat(string word, int count)
            {

                for (int i = 0; i < count; i++)
               {
                 Console.Write(word);

                if (count - i > 1){

                     Console.Write(" ");
                 }
           }
   }