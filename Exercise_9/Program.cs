// See https://aka.ms/new-console-template for more information
using System.IO;
Console.WriteLine("Hello, World!");

string Content = File.ReadAllText(@"C:\Assignment\Udemy\James_Bond.txt");

//Console.WriteLine(Content);

int spaceCount = 0;
//List<int> l1 = new List<int>();

for(int i = 0; i < Content.Length; i++)
{
    if (Content[i] == ' ')
    {
        spaceCount++;
    }
}

Console.WriteLine($"Total word count ={spaceCount+1}");

//int chlength = 0;
//for (int i = 0; i < Content.Length; i++)
//{
//    if (Content[i] != ' ')
//    {
//        chlength++;
//    }

//    if (Content[i]==' ')
//    {

//    }
//}
string[] str = Content.Split();

//foreach(var item in str)
//{
//    Console.WriteLine(item);
//}

//string longestWord = string.Empty ;
//for(int i = 0; i < str.Length -1; i++)
//{
//    if (str[i].Length > str[i + 1].Length)
//    {
//        longestWord = str[i];
//    }
//    else
//    {
//        longestWord = str[i + 1];
//    }

//    if (longestWord.Length < str[i + 1].Length)
//    {
//        longestWord=
//    }
//}

//Console.WriteLine(longestWord);

string LongestWord = str[0];

for (int i = 0; i < str.Length - 1; i++)
{
    if (str[i].Length > LongestWord.Length)
    {
        LongestWord = str[i];
    }
}
Console.WriteLine(LongestWord);