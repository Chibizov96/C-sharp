// Написать программу вычисления значения функции y=f(a)
int Function(int x)
{
    int y = 2 * x + 3;
    return y;
}

Console.WriteLine("Введите число x для рассчета y по функции y=2x+3 :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваш ответ: " + Function(x));