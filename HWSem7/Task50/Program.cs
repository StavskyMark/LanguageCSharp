// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;
Clear();

WriteLine("Input 6 parameters:");
WriteLine("Size of desired array. M, N - int Values");
WriteLine("Begin and end Values for random generate array(int or double Values))");
WriteLine("index x, index y of element which we want to check for it's value: ");
WriteLine();

string[] parametersString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

if (parametersString.Length > 6)
{
    WriteLine("Warning! 6 parameters required. Al other will be casted aside!");
}
if ((parametersString.Length < 6))
{
    WriteLine("Error. Exactly 6 parameters required! Now Exit");
    Environment.Exit(0);
}


int sizeM = CheckInput(parametersString[0], "Only Int allowed");
int sizeN = CheckInput(parametersString[1], "Only Int allowed");
int indexX = CheckInput(parametersString[4], "Only Int allowed");
int indexY = CheckInput(parametersString[5], "Only Int allowed");
if (sizeM <= 0 || sizeN <= 0)
{
    WriteLine("Error! Array size must be above zero! Terminate progr!");
    Environment.Exit(0);
}
if (indexX < 0 || indexY < 0)
{
    WriteLine("Error! Index in array can't be negative! Terminate progr!");
    Environment.Exit(0);
}

if (indexX >= sizeM || indexY >= sizeN)
{
    WriteLine($"There is not index[{indexX},{indexY}] in array of size [{sizeM},{sizeN}] - out of range");
    Environment.Exit(1);
}

if ((int.TryParse(parametersString[2], out int BeginRandInt)) && (int.TryParse(parametersString[3], out int EndRandInt)))  // Generate int filled Array
{
    int[,] array = GenerateIntMNArray(Convert.ToUInt32(sizeM), Convert.ToUInt32(sizeN), BeginRandInt, EndRandInt);
    PrintIntMNArray(array);
    WriteLine($"element{indexX}{indexY} = {array[indexX,indexY]}");

}
else if ((double.TryParse(parametersString[2], out double BeginRand)) && (double.TryParse(parametersString[3], out double EndRand)))  // Generate double filled Array
{   
double[,] array = GenerateDoubleMNArray(Convert.ToUInt32(sizeM), Convert.ToUInt32(sizeN), BeginRand, EndRand);;
    PrintDoubleMNArray(array);
    WriteLine($"element[{indexX},{indexY}] = {array[indexX,indexY]}");

}
else
{
    WriteLine("Only Int or double values allowed for begin and end range of array");
    Environment.Exit(0);
}

int[,] GenerateIntMNArray(uint sizeM, uint sizeN, int BeginArr, int EndArr)
    {
        if (sizeM == 0 || sizeN == 0)
        {
            WriteLine("Size can't be zero. Now terminate all progr");
            Environment.Exit(0);
        }

        int[,] result = new int[sizeM, sizeN];
        Random rnd = new Random();
        for (int i = 0; i < sizeM; i++)
        {
            for (int j = 0; j < sizeN; j++)
            {
                result[i, j] = rnd.Next(BeginArr, EndArr + 1);
            }
        }
        return result;
    }


    

double[,] GenerateDoubleMNArray(uint sizeM, uint sizeN, double BeginArr, double EndArr)
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

void PrintIntMNArray(int[,] inArray)
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

void PrintDoubleMNArray(double[,] inArray)
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Write($" {inArray[i, j]}");
                //Write($" {string.Format("{0:f4}", inArray[i,j])}"); 
            }
            WriteLine();
        }
    }

int CheckInput(string inString, string errorMsg)
{
    if (!int.TryParse(inString, out int result))
    {
        WriteLine($"{inString} -> (int):  {errorMsg}. Now exit!");
        Environment.Exit(0);
    }
    return result;
}
