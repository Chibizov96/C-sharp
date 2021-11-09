// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Введите х точки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите у точки: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 | y == 0) Console.WriteLine("Координаты должны отличаться от нуля");
if (x > 0 & y > 0) Console.WriteLine("1я четверть");
if (x < 0 & y > 0) Console.WriteLine("2я четверть");
if (x < 0 & y < 0) Console.WriteLine("3я четверть");
if (x > 0 & y < 0) Console.WriteLine("4я четверть");