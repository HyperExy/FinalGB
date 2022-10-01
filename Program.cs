string[] CreateArr(int n)
{
    string[] Arr = new string[n];
    for(int i = 0; i < n; i++)
    Arr[i] = Console.ReadLine();
    return Arr;
}
int Count(string[] arr, int l)
    {
        int count = 0;
        for(int i = 0; i < arr.Length; i++)
            if(arr[i].Length <= l)
                count++;
    return count;
    }
int N, L = 3, b = 0;

Console.WriteLine("Enter the size of array");

N = Convert.ToInt32(Console.ReadLine());

string[] MasStr = CreateArr(N);

string[] NewMas = new string[Count(MasStr, L)];

for(int i = 0; i < N; i++)
{
    if(MasStr[i].Length <= L)
        {
        NewMas[b] = MasStr[i];
        b++;
        }
}

Console.WriteLine("New array:");

for(int i = 0; i < b; i++)
{
    Console.WriteLine($"{NewMas[i]}");
}
