// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter name");
string str = Console.ReadLine();

char[] arr = new char[str.Length];

for(int i = 0; i < str.Length; i++)
{
    arr[i] = str[i];
}



Array.Reverse(arr);

string result = string.Empty;

for(int i = 0; i < arr.Length; i++)
{
    result = result + arr[i];
}

Console.WriteLine(result);