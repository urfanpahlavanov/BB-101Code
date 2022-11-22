// See https://aka.ms/new-console-template for more information
using Urfancodeacademy;

BuilderString bs = new BuilderString();

bs.Append('1');
bs.Append('a');
bs.Append('b');
bs.Append('c');
Console.WriteLine(bs);
Console.WriteLine(bs.Capacity);
Console.WriteLine(bs.Replace('1', '3'));
Console.WriteLine(bs.Remove('a'));  
