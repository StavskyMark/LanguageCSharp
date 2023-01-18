using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

Write("Введите степень: ");
int n = int.Parse(ReadLine()!);
int d = 0;
int i = 1;

Degree();



int Degree()
{
    while (d < n)
{    
    i = i * number;
    d++;
}
    return i;
}

WriteLine($"{number} в {n} степени = {Degree}");

