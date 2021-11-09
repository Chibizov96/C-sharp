//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int y = Convert.ToInt32(Console.ReadLine());

void Method(int a, int b)
{
    if (b * b == a)
    {
        Console.WriteLine("Первое число является квадратом второго");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго");
    }
}


Method(x, y);