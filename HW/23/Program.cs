// Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число N");
int x = Convert.ToInt32(Console.ReadLine());
void Method(int n)
{
    for (int i = 1; i < n + 1; i++)
    {
        Console.WriteLine(i + " в квадрате равно: " + i * i);
    }
}
Method(x);