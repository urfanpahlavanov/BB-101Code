
string path = @"C:\Users\CP\source\repos\ProectDirectory\Folder\";

Folders(path);
void  Folders(string path,string cavity=" ")
{
    var return1=Directory.GetDirectories(path);
    var return2=Directory.GetFiles(path);

    foreach(var item in return1)
    {
        Console.WriteLine(cavity+item);
        if (Directory.CreateDirectory(item).Exists)
        {
            cavity=cavity+item; 
            Folders((string)item,cavity);   
        }
        else
        {
            cavity = String.Empty;
            Folders(path,cavity);
        }
    }
    foreach(var item in return2)
    {
        Console.WriteLine(cavity+item);
    }

}

