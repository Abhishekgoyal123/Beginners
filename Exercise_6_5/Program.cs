
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
while(true)
{
    string str = Console.ReadLine();

    string[] str1 = str.Split(' ');

    if (str1.Length<=3)
    {
        Console.WriteLine("invalid list, retry");
    }
    List<int> l1 = new List<int>();
    for (int i = 0; i < str.Length - 1; i++)
    {
        int a = Convert.ToInt32(str[i]);

        l1.Add(a);
    }
    
    
}
