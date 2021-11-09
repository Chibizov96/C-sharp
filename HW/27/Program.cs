// Определить количество цифр в числе
Console.WriteLine("Количество цифр понял как количество разрядов");
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (a / 10 != 0)
{
    count = count + 1;
    a = a / 10;
    Console.WriteLine(a);
}
Console.WriteLine("Количество цифр равно: " + count);

