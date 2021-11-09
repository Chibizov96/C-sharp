// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
void Method(int number)
{
    if (number < 100 | number > 999) Console.WriteLine("Число не трехзначное");
    else
    {
        Console.Write("Вторая цифра: ");
        Console.WriteLine(number % 100 / 10);
    }
}
Method(num);
