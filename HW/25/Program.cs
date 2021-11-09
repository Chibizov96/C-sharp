// Найти сумму чисел от 1 до N
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i < n + 1; i++)
{
    sum += i;
}
Console.WriteLine("Сумма чисел от 1 до " + n + " равна: " + sum);