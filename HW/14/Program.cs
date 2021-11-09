// Найти третью цифру числа или сообщить, что её нет
int num = new Random().Next(-100000, 100000);
Console.WriteLine("Ищем третью справа цифру (количество сотен)");
void Method(int number)
{
    Console.WriteLine("Рандомное число с отрезка: " + number);
    number = Math.Abs(number);
    if (number < 100) Console.WriteLine("Третья цифра отсутствует");
    else Console.WriteLine("Третья справа цифра в числе: " + (number / 100 % 10));
}
Method(num);