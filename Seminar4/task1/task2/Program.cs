using static System.Console;
Clear();

WriteLine("Введите число:" );
int Number = int.Parse(ReadLine()!);

int mult = Getmult(Number);
WriteLine($"Произведение от 1 до N равно {mult}");


int Getmult(int A)
{
    int result = 1;

    while (A>0)
    {
        result*=A;
        --A;
    }

    return result;
}

