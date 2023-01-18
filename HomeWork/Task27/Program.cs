using static System.Console;
Clear();

 Write("Введите число: ");
 int i = Convert.ToInt32(ReadLine()!);

 int Sum = GetSum(i);
 WriteLine($"Сумма чисел = {Sum}");



 int GetSum(int A)
 {
     int result = 0;
     while (A > 0)
     {
        int d = i % 10;
         result += d;
         i = i/10;
         A--;
     }
     return result;
 }
