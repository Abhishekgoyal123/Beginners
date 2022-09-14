// See https://aka.ms/new-console-template for more information
using Ref_Val;
Console.WriteLine("Hello, World!");

Class1 c1 = new Class1();
c1.Age = 10;


int number = 100;

static void func1(int number)
{
    number += 10;
}
func1(number);
Console.WriteLine(number);


static void func(Class1 c1)
{
    c1.Age += 10; 
}
//Console.WriteLine(c1.Age);
func(c1);
Console.WriteLine(c1.Age);

