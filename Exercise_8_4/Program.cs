// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string abc = Console.ReadLine();

string [] arr = abc.Split(' ');

string result = string.Empty;

foreach(var item in arr)
{
    Console.WriteLine(item);
}
foreach(var characters in arr){


    result += char.ToUpper(characters[0]) + characters.ToLower().Substring(1);
}

Console.WriteLine(result);