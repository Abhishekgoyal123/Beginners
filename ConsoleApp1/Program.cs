// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a = 10;

double d = 1.2f;


// OVERFLOWING
byte b1 = 105;
byte b2 =  1;
byte b3 = (byte)(b1 + b2);
Console.WriteLine(b1.GetType());

Console.WriteLine("{0} {1}" , byte.MaxValue , byte.MinValue);

string s = "123";

int a1 = int.Parse(s);
Console.WriteLine(a1);