// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = new Random().Next(10, 100);

void Method(int number)
{
    Console.Write("Рандомное число с отрезка: ");
    Console.WriteLine(number);
    Console.Write("Наибольшая цифра числа: ");
    int secondnumber = number % 10;
    int firstnumber = (number - secondnumber) / 10;
    if (firstnumber > secondnumber)
    {
        Console.WriteLine(firstnumber);
    }
    else Console.WriteLine(secondnumber);
}
Method(num);