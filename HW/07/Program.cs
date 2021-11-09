// Показать числа от -N до N
Console.Write("Введите число N: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Числа от -max  до max: ");

void Method(int maximum)
{
    int minimum;
    minimum = -maximum;
    while (minimum <= maximum)
    {
        Console.Write(minimum + " ");
        minimum++;
    }
}
Method(max);