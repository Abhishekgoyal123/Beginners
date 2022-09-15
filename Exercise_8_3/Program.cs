// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string time = Console.ReadLine();

string [] abc = time.Split(':');

if (Convert.ToInt32(abc[0]) >=00 && Convert.ToInt32(abc[0]) <= 23 && Convert.ToInt32(abc[1]) >= 00 && Convert.ToInt32(abc[1]) <= 59)
{
    Console.WriteLine("ok");
}
else
    Console.WriteLine("invalid time");

