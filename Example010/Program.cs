using static System.Console;
Clear();

Write("Введите число: ");
int number1 = int.Parse(ReadLine());

WriteLine(number1 % 7 == 0 && number1 % 23 == 0? "Кратное":"Некратное");
