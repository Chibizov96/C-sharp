// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
string Method(int first, int second)
{
    string text = string.Empty;
    if ((first * first == second) || (second * second == first)) text = "Одно число является квадратом другого";
    else text = "Числа не являются квадратами друг друга";
    return text;
}

Console.WriteLine(Method(a, b));