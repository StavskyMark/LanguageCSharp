using static System.Console;
Clear();

Write("Введите k1: ");
int k1 = int.Parse(ReadLine());
Write("Введите b1: ");
int b1 = int.Parse(ReadLine());
Write("Введите k2: ");
int k2 = int.Parse(ReadLine());
Write("Введите b2: ");
int b2 = int.Parse(ReadLine());
 
 
int x = (b1 - b2) / (k1 - k2);
int y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
WriteLine($"Пересечение в точке: ({x};{y})");
