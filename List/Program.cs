// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> l1 = new List<int> { 1, 2, 3 };

l1.Add(1);



Console.WriteLine($"index of 1 : {l1.IndexOf(2)}");

//foreach(int i in l1)
//{
//    if (i == 1)
//    {
//        l1.Remove(i);
//    }
//}

for (int i = 0; i < l1.Count; i++)
{
    if (l1[i] == 1)
        l1.Remove(l1[i]);
}


foreach (int i in l1)
{
    Console.WriteLine(i);
}