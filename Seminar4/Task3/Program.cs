using static System.Console;
Clear();

int [] arr = GetArray();

GetArray();
PrintArray(arr);


void FullArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
}

int[] GetArray ()
{
    int [] arr = new int [8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(2);
    }
    return arr;
}

void PrintArray (int [] arr)
{
    for (int i =0; 1 < arr.Length; i++)
    {
        WriteLine($"{arr[i]} ");
    }
}