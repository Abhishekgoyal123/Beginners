// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var Input = Convert.ToDateTime(Console.ReadLine());

if(Input.Hour >= 00 && Input.Hour <= 23  && Input.Minute>= 00 && Input.Minute<=59)
{
    Console.WriteLine("ok");
}
else
{
    Console.WriteLine("invalid time");
}
