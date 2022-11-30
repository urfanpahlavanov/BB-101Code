// See https://aka.ms/new-console-template for more information

using CustomList;

internal class Program
{
    private static void Main(string[] args)
    {
        MyList<string> myList = new MyList<string>(5);

        myList.Add("urfan");
        myList.Add("resul");
        myList.Add("nasir");
        myList.Add("elcin");  
        myList.Add("sona");
        
        foreach (var item in myList.list)
        {
            Console.WriteLine(item);
           
        }
       
    }

      
}