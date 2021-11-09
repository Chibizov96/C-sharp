// Найти третью цифру числа или сообщить, что её нет
int number = new Random().Next(1, 100000);
Console.WriteLine("Ищем третью справа цифру (количество сотен)");
Console.WriteLine("Рандомное число с отрезка: " + number);
if (number < 100) Console.WriteLine("Третья цифра отсутствует");
else Console.WriteLine("Третья справа цифра в числе: " + (number / 100 % 10));
