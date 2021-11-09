// Дано число. Проверить кратно ли оно 7 и 23
int num = new Random().Next(1, 100000);
void Method(int number)
{
    Console.WriteLine("Рандомное число с отрезка: " + number);
    if ((number % 7 == 0) & (number % 23 == 0))
    {
        Console.WriteLine("Число кратно 23 и 7");
    }
    else
    {
        Console.WriteLine("Число некратно 23 и 7");
    }
}
Method(num);