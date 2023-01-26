using static System.Console;
Clear();



Write("Введите элементы через пробел: ");
int[] arr = Array.ConvertAll(ReadLine().Split(), int.Parse);

 int CountNull()
{
    int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
}
WriteLine($"Кол-во элементов > 0: {count}");