// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int mod = 1;
for (int i = 1; i < n + 1; i++)
{
    mod = mod * i;
}
Console.WriteLine("Произведение чисел от 1 до " + n + " равно: " + mod);
