// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());
void Method(int first, int second)
{
    if (first > second)
    {
        Console.WriteLine("Большее первое - " + first);
        Console.WriteLine("Меньшее второе - " + second);
    }
    else if (first == second)
    {
        Console.WriteLine("Числа равны");
    }
    else
    {
        Console.WriteLine("Большее второе - " + second);
        Console.WriteLine("Меньшее первое - " + first);
    }
}
Method(first, second);