// See https://aka.ms/new-console-template for more information
using System.IO;

Console.WriteLine("Hello, World!");

string path = @"C:\Assignment\Udemy\MyFile1.txt";

//var content = File.ReadAllText(@"C:\Assignment\Udemy\MyFile1.txt");
//Console.WriteLine(content);

FileInfo fi = new FileInfo(path);

Console.WriteLine(fi.OpenText()); 


Directory.CreateDirectory(@"C:\Assignment\Udemy2");