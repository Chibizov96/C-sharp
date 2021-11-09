// Определить количество цифр в числе
Console.WriteLine("Количество цифр понял как количество разрядов");
Console.WriteLine("Введите число A");
int x = Convert.ToInt32(Console.ReadLine());
int number(int a)
{
    int count = 1;
    while (a / 10 != 0)
    {
        count = count + 1;
        a = a / 10;
    }
    return count;
}
Console.WriteLine("Количество цифр равно: " + number(x));

