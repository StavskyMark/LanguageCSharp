/*Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.*/


int [,] array = GetArray(8,3);
PrintArray(array);
Console.WriteLine();
SearchArrayRowsMinimalSum(array);

/// Создание случайного двумерного массива
int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(0, 10);
                }
            }
    return array;
}

/// Метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Console.Write("{0,6}", array[i, j]);
        }
        Console.WriteLine();
    }
}

///Метод поиска строки с наименьшей суммой элементов
void SearchArrayRowsMinimalSum (int [,] array)
{
    int sumFirstString = 0;
    int sumSecondString = 0;
    int minString = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sumFirstString = sumFirstString + array[i, j];
            }

            if (sumSecondString == 0)
            {
                sumSecondString = sumFirstString;
            }

            if (sumFirstString < sumSecondString)
            {
                sumSecondString = sumFirstString;
                minString = i + 1;
            }
            Console.WriteLine($"Сумма каждой строки {sumFirstString}");
            sumFirstString = 0;
        }
    Console.WriteLine();
    Console.WriteLine($"Строка массива с минимальным значением = {minString}");
}




