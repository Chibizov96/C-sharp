// Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
Console.Write("Рандомное число с отрезка: ");
Console.WriteLine(number);
int newnumber = number / 100 * 10 + number % 10;
Console.WriteLine(newnumber);