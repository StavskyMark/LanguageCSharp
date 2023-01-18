using static System.Console;
Clear();

// Write("Введите кол-во сделаных деталей за смену: ");
// int n = Convert.ToInt32(ReadLine()!);
// int result = n%6;

// if( result == 0) WriteLine($"Младшие токари сделали по {n/6} детали, старший - {n/6*4} деталей");
// else WriteLine("Старший токарь ошибся");

Write("Введите кол-во деталей: ");
int count_detal = Convert.ToInt32(ReadLine()!);
Write("Введите кол-во токарей 1 разряда: ");
int count_tokar1 = Convert.ToInt32(ReadLine()!);
Write("Введите кол-во токарей 4 разряда: ");
int count_tokar4 = Convert.ToInt32(ReadLine()!);

int tokar1 = 1;
int tokar4 = 2*(tokar1 + tokar1);

int sum_proizvod = tokar1*count_tokar1+tokar4*count_tokar4;

if (count_detal%sum_proizvod == 0)
{
    WriteLine("Это правда!");
    WriteLine($"Каждый токарь 1 разр. сделал {count_detal/sum_proizvod*tokar1}");
    WriteLine($"Каждый токарь 4 разр. сделал {count_detal/sum_proizvod*tokar4}");    
}
else WriteLine("Они лгут!");
