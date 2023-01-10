using static System.Console;
Clear();

Write("Введите число a: ");
int a = int.Parse(ReadLine());
Write("Введите число b: ");
int b = int.Parse(ReadLine());

WriteLine(a == b? "=": a > b? ">" : "<");











//using static System.Console;
//Clear();

// Вид 1
void Method1()
{
    WriteLine("Автор: Константин Малышев");
}

//Method1();



//Вид 2

void Method2 (string msg)
{
    WriteLine(msg);  
}
//Method2("Текст сообщения");

void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Текст", count: 4);
//Method21("Текст", 4);



//Вид 3

int Method3 ()
{
    return DateTime.Now.Year;    
}

int Year = Method3();
//WriteLine(Year);



//Вид 4

//string Method4 (int count, string text)
//{
//    int i = 0;
//    string result = string.Empty;
//
//    while (i < count)
//    {
//        result = result + text;
//        i++;
//    }
//    return result;
//}

//string res = Method4(10, "Kostya ");
//WriteLine(res);


//Цикл for

string Method4 (int count, string text)
{
    string result = string.Empty;
    for ( int i = 0; i < count;  i++) 
    {
        result = result + text;
    }
    return result;
}

string result = Method4(10, "Kostya ");
//WriteLine(result);



//Цикл в цикле

for (int i = 2; i < 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {     
        WriteLine($"{i} x {j} = {i*j}");   
    }
    WriteLine();
}


