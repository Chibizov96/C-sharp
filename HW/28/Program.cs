// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a / 10 != 0)
{
    sum = sum + a % 10;
    Console.WriteLine("sum = " + sum);
    a = a / 10;
    Console.WriteLine("а = " + a);
}
sum = sum + a;
Console.WriteLine("Сумма цифр равна: " + sum);