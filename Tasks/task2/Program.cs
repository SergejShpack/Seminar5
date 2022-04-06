// Показать числа Фибоначчи


void FibonacciMethod(int num)
{
    long a1 = 0;
    long a2 = 1;

    Console.Write(a1 + " " + a2 + " ");
    for (int i = 3; i <= num; i++)
    {
        Console.Write((a1 + a2) + " ");
        a2 = a1 + a2;
        a1 = a2 - a1;
    }
}

long FibonacciRecursion(int num)
{
    if (num == 2 || num == 3) return 1;
    else return (FibonacciRecursion(num - 1) + FibonacciRecursion(num - 2));
}

void PrintFibonacciRecursion(int num)
{
    long a1 = 0;
    long a2 = 1;

    Console.Write(a1 + " " + a2 + " ");
    for (int i = 3; i <= num; i++)
    {
        Console.Write(FibonacciRecursion(i) + " ");
    }
}


Console.Write("Введите длину последовательности Фибоначчи >=2): ");
int number = int.Parse(Console.ReadLine() ?? "5");


PrintFibonacciRecursion(number);

Console.WriteLine();
if (number >= 2) FibonacciMethod(number);
else Console.WriteLine("Слишком маленькое число");
Console.WriteLine();