// Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();

Write("Введите число: " );
int N = int.Parse(ReadLine());

PrintNumbers (N);




void PrintNumbers(int num)
{
    if (num < 0) Write($"{num} не натуральное число");
    if (num == 1) Write(num);
    else
    {
        Write($",{num} "); 
       PrintNumbers(num - 1);
       
    } 
}