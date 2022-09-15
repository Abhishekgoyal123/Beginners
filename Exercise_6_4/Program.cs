// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string str = Console.ReadLine();


List<int> list = new List<int>();

while (str!="Quit")
{
   list.Add(int.Parse(str)); 
    str = Console.ReadLine();
}

list = list.Distinct().ToList();

