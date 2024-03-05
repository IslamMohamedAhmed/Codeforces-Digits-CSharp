int T;
string[] N = new string[12];

T = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < T; i++)
{
    N[i] = Console.ReadLine();
}
for(int i = 0; i < T; i++)
{
    string str = N[i];
    for(int j= str.Length-1; j >= 0; j--)
    {
        Console.Write(str[j]+" ");
    }
    Console.WriteLine();
}
