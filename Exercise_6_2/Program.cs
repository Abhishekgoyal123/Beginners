// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("enter name");
string str = Console.ReadLine();

char[] arr = new char[str.Length];

for(int i = 0; i < str.Length-1; i++)
{
    arr[i] = str[i];
}

char[] arr1 = new char[str.Length];

for(int j = 0; j < str.Length-1; j++)
{
    arr1[j] = arr[(str.Length) - j];
}

string str1 = new string(arr1);
Console.WriteLine(str1);