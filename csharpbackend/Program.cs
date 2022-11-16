class Task
{
    private static void Main1(){

        Console.WriteLine("Enter numbers");
        int number= Convert.ToInt32(Console.ReadLine());
        int [] array=new int[number];
        int sum=0;

        for(int i=0;i<number;i++){
            Console.WriteLine("element["+(i+1)+"]:");
            array[i]=int.Parse(Console.ReadLine());
        if(array[i]%2==0){

                sum+=array[i];
            }

        }
       

        Console.WriteLine("even numbers sum="+sum);

        

    }
}