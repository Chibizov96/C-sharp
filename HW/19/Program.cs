// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Введите х точки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у точки: ");
int y = Convert.ToInt32(Console.ReadLine());
void Method(int a, int b)
{
    if (a == 0 | b == 0) Console.WriteLine("Координаты должны отличаться от нуля");
    if (a > 0 & b > 0) Console.WriteLine("1я четверть");
    if (a < 0 & b > 0) Console.WriteLine("2я четверть");
    if (a < 0 & b < 0) Console.WriteLine("3я четверть");
    if (a > 0 & b < 0) Console.WriteLine("4я четверть");
}
Method(x, y);