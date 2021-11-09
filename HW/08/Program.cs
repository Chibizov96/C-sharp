// Показать четные числа от 1 до N
Console.Write("Введите число N: ");
int maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void Method(int maximum)
{
    for (int i = 1; i < maximum + 1; i++)
    {
        if (i % 2 == 0) Console.Write(i + " ");
    }
}