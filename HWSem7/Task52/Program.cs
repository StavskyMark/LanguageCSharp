// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


/// доделать

using static System.Console;
Clear();

WriteLine("Input 4 parameters:");
WriteLine("Size of desired array. M, N - int Values");
Write("Begin and end Values for random generate array(int or double Values)): ");

string[] parametersString = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
WriteLine();

if (parametersString.Length > 4)
{
    WriteLine("Warning! 4 parameters required. Al other will be casted aside!");
}
if ((parametersString.Length < 4))
{
    WriteLine("Error. Exactly 4 parameters required! Not Less! Now Exit!");
    Environment.Exit(0);
}

int sizeM = CheckInput(parametersString[0], "Only Int allowed");
int sizeN = CheckInput(parametersString[1], "Only Int allowed");
int beginRand = CheckInput(parametersString[2], "Only Int allowed");
int endRand = CheckInput(parametersString[3], "Only Int allowed");

if (sizeM <= 0 || sizeN <= 0)
{
    WriteLine("Error! Array size must be above zero! Terminate progr!");
    Environment.Exit(0);
}
int[,] array = GenerateIntMNArray(Convert.ToUInt32(sizeM), Convert.ToUInt32(sizeN), beginRand, endRand);
PrintIntMNArray(array);

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

double[] ArifmMean = ArifmeticMean(array);
Write("Arifmetical mean for every Column of the array is:[");
for(int i =0; i < ArifmMean.Length -1; i ++)
{
    Write($"{ArifmMean[i]}, ");
}
WriteLine($"{ArifmMean[ArifmMean.Length-1]}]");

WriteLine();



double[] ArifmeticMean(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)];
    

    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        result[j] = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            result[j] += inArray[i, j];
        }
        result[j] /= inArray.GetLength(0);

    }

    return result;
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
