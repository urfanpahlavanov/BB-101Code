// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("*******Delegate Generics*******");
int[] arr = { 1, 2, -1, 3, 4, 5 };
Check check = new Check(Return);
foreach (var item in FindAll(arr, check))
{
    Console.WriteLine(item);
}


 int[] FindAll(int[] arr,Check func)
{
    int[] arr1 = { };
    foreach(int item in arr)   
    {
        if (func(item))
        {
            arr1.Append(item);  
        }
    }
    return arr1;
    
}

bool Return(int item) => item > 2;


delegate bool Check(int item);
