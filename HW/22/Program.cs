// Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine("введите размерность пространства (2 или 3)");
int dimens = Convert.ToInt32(Console.ReadLine());

double Distance(int dimension)
{
    Console.WriteLine("введите x1");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите x2");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите y1");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите y2");
    int y2 = Convert.ToInt32(Console.ReadLine());
    double distance = 0;
    if (dimension == 2)
    {
        Console.WriteLine("Координаты первой точки " + "(" + x1 + "; " + y1 + ")");
        Console.WriteLine("Координаты первой точки " + "(" + x1 + "; " + y1 + ")");
        distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }
    else if (dimension == 3)
    {
        Console.WriteLine("введите z1");
        int z1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите z2");
        int z2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Координаты первой точки " + "(" + x1 + "; " + y1 + "; " + z1 + ")");
        Console.WriteLine("Координаты второй точки " + "(" + x2 + "; " + y2 + "; " + z2 + ")");
        distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    }
    else Console.WriteLine("Вы ввели неверное количество измерений. Допустипо 2 или 3");

    return distance;
}
Console.WriteLine("Расстояние между точками равно " + Distance(dimens));