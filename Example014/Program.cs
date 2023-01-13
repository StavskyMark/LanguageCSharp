using static System.Console;
Clear();

Write("Введите кол-во сделаных деталей за смену: ");
int n = Convert.ToInt32(ReadLine()!);
int result = n%6;

if( result == 0) WriteLine($"Младшие токари сделали по {n/6} детали, старший - {n/6*4} деталей");
else WriteLine("Старший токарь ошибся");

