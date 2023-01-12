using static System.Console;
Clear();

WriteLine("Введите чисто a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());
int total = a + b - 1;

//WriteLine(a * a == b? "b является квадратом a":b * b == a? "a является квадратом b":"Числа не являются квадратами друг друга");

WriteLine("Всего было банок " + total );