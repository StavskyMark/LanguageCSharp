using static System.Console;


// Write("Input number1: ");
// int number1 = int.Parse(ReadLine()!);

// int sum1=GetSum(number1);
// WriteLine($"Sum number 1..A = {sum1}");
// WriteLine(number1);

// int GetSum(int A)
// {
//     int result = 0;
//     while(A > 0)
//     {
//         result += A;
//         A--;
//     }

//     return result;
// }

WriteLine("Введите число: ");
int number = Convert.ToInt32 (ReadLine()!);
int count = Numbers(number);



int Numbers(int A)
{
    int result = 0;

    while(A > 0)
    {
        A = A / 10;
        result ++;
    }

    
}