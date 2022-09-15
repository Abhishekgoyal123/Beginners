// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string abc;
//int flag;
Console.WriteLine("enter numbers seperated by hyphen");
abc = Console.ReadLine();

//for(int i = 0; i < abc.Length; i++)
//{
//    int flag;
//    if(abc[i] == '-')
//    {
//        if (Convert.ToInt32(abc[i-1]) - Convert.ToInt32(abc[i+1]) == 1)
//        {
//            //flag = 0;
//            //Console.WriteLine("not consecutive");
//            //break;
//            continue;

//        }

//    }
//    else
//    {
//        Console.WriteLine("non consecutive");
//        break;
//    }


//}

string[] str = abc.Split('-');

foreach(var item in str)
{
    Console.WriteLine(item);
}

List<int> l1 = new List<int>();
for(int i = 0; i < str.Length-1; i++)
{
    int a= Convert.ToInt32(str[i]) - Convert.ToInt32(str[i + 1]);

    l1.Add(a);
}



