// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;
using MyLibArray;
Clear();

WriteLine("Input 4-5 parameters separated by space: ");
WriteLine("M,N - size of array(int values!)");
WriteLine("Begin and end of Random values (double type) - use comma, not dot");
Write("Accuracy after dot. (in case of need only): ");

string[] parametersString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);


if (parametersString.Length >5)
{
    WriteLine("Warning!!! Only 5 parameters read. other will be casted aside.");
}

if (parametersString.Length < 4)
{
    WriteLine("At least 4 parameters required!. Now exit!");
    Environment.Exit(0);
}
else
{
    uint sizeM = 0;
    uint sizeN=0;
    double BeginRand = 0;
    double EndRand =0;
    int Accuracy =0;

    sizeM = CheckIntInput(parametersString[0], "Only int value allowed! (sizeM) now exit!");
    sizeN = CheckIntInput(parametersString[1], "Only int value allowed! (sizeN) now exit!");
    BeginRand = CheckDoubleInput(parametersString[2], "Only double(or int) values allowed! (Begin rand) now exit!");
    EndRand = CheckDoubleInput(parametersString[3], "Only double(or int) values allowed!(End Rand) now exit!");
    
    if (parametersString.Length == 5)
    {
        Accuracy = Convert.ToInt32(CheckIntInput(parametersString[4], "Only int value allowed! (Accuracy) now exit!"));

WriteLine();

double[,] array = GenerateDoubleMNArray;
PrintDoubleMNArray();
    }
    else
    {
        double[,] array = GenerateDoubleArray;
        PrintDoubleMNArray();
    } 





double[,] GenerateDoubleMNArray(uint sizeM, uint sizeN, double BeginArr, double EndArr, int accuracy)
    {
        if (sizeM == 0 || sizeN == 0)
        {
            WriteLine("Size can't be zero. Now terminate all progr");
            Environment.Exit(0);
        }

        double[,] result = new double[sizeM, sizeN];
        Random rnd = new Random();
        for (int i = 0; i < sizeM; i++)
        {
            for (int j = 0; j < sizeN; j++)
            {
                result[i, j] = Math.Round((BeginArr + rnd.NextDouble() * (EndArr - BeginArr)), accuracy);
            }
        }
        return result;
    }  

void PrintDoubleMNArray(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($" {inArray[i, j]}");
            }
            WriteLine();
        }
    }
    
      


      double[,] GenerateDoubleArray(uint sizeM, uint sizeN, double BeginArr, double EndArr)
    {
        if (sizeM == 0 || sizeN == 0)
        {
            WriteLine("Size can't be zero. Now terminate all progr");
            Environment.Exit(0);
        }

        double[,] result = new double[sizeM, sizeN];
        Random rnd = new Random();
        for (int i = 0; i < sizeM; i++)
        {
            for (int j = 0; j < sizeN; j++)
            {
                result[i, j] = BeginArr + rnd.NextDouble() * (EndArr - BeginArr);
            }
        }
        return result;
    }

void PrintDoubleMNArray(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($" {inArray[i, j]}");
            }
            WriteLine();
        }
    }




uint CheckIntInput(string inString, string errorMsg)
{
    if (uint.TryParse(inString, out uint result))
    {
        WriteLine(errorMsg);
        Environment.Exit(0);
    }
    return result;
}

double CheckDoubleInput(string inString, string errorMsg)
{
    if (!double.TryParse(inString, out double result))
    {
        WriteLine(errorMsg);
        Environment.Exit(0);
    }
    return result;
}
