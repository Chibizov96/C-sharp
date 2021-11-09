// Показать таблицу квадратов чисел от 1 до N 
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    Console.WriteLine(i + " в квадрате равно: " + i * i);
}
