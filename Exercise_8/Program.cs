// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string abc;
//int flag;
Console.WriteLine("enter numbers seperated by hyphen");
abc = Console.ReadLine();

string[] str = abc.Split('-');

for(int i = 0; i < str.Length-1; i++)
{
    for(int j = i+1; j < str.Length; j++)
    {
        if (str[i] == str[j])
        {
            Console.WriteLine("duplicate");
            break;
        }
       
    }
   
    
    
}
int dif = Convert.ToInt32(str[1]) - Convert.ToInt32(str[0]);
for (int i = 0; i < str.Length-1; i++)
{

    if(Convert.ToInt32(str[i+1]) - Convert.ToInt32(str[i]) != dif)
    {
        Console.WriteLine("Not consecutive");
        return;
    }

}
Console.WriteLine("consecutive");




