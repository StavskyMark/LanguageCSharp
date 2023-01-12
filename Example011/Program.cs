using static System.Console;
Clear();

WriteLine("Введите чисто a: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

//if (a * a == b || b * b == a)

WriteLine(a * a == b? "b является квадратом a":b * b == a? "a является квадратом b":"Числа не являются квадратами друг друга");

