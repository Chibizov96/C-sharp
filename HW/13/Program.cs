﻿// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("введите число, которое проверяется на кратность:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число, которому должно быть кратно: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0) Console.WriteLine("Число кратно");
else Console.WriteLine("Остаток от деления числа " + a + " на число " + b + " равен " + a % b);