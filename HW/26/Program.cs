//Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int y = Convert.ToInt32(Console.ReadLine());
int Modify(int a, int b)
{
    int mod = a;
    for (int i = 1; i < b; i++) mod = mod * a;
    return mod;
}

Console.WriteLine(x + " в степени " + y + " равно: " + Modify(x, y));
