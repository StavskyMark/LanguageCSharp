using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] parameters = Readline()!.Split(" ",stringSplitOptions.RemoveEmptyEntries);

CountNull();

int CountNull ()
{
    int count = 0;
    for (int i = 0; i < parameters.Length; i++)
    {
        if (parameters[i] > 0);
        {
            count ++;
        }  
        WriteLine($"Кол-во элементов > 0: {count}");
    }
}

