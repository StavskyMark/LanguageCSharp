/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
using static System.Console;
Clear();


Write("Введите начальное число M: ");
int numberM = int.Parse(ReadLine());

Write("Введите начальное число M: ");
int numberN = int.Parse(ReadLine());

GapNumberSum(numberM, numberN, 0);


void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Write($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

