// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("enter name");
string str = Console.ReadLine();

string[] abc = str.Split(' ');

if(abc.Length == 0)
{
    Console.WriteLine("no one liked");
}

for(int i = 0; i < abc.Length-1; i++)
{
    if (abc.Length == 1)
    {
        Console.WriteLine($"{abc[i]} liked your post");
    }

    if (abc.Length == 2)
    {
        Console.WriteLine($"{abc[i]} and {abc[i+1]} liked your post");
    }

    if(abc.Length>2)
    {
        int count = 0;
        Console.WriteLine($"{abc[i]},{abc[i + 1]} and {(abc.Length)-2} liked your post");
        break;
    }
}
