
int[] arr = new int[5];

for(int i = 0; i < arr.Length; i++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    while (arr.Contains(input))
    {
        Console.WriteLine("Enter the correct no");
        input = Convert.ToInt32(Console.ReadLine());    
    }
    arr[i] = input;

}
Array.Sort(arr);
for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}