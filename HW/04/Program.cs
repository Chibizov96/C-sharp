// Найти максимальное из трех чисел
int first = 14;
int second = 12;
int third = 32;
int max = first;
if (first < second) max = second;
if (max < third) max = third;
Console.WriteLine("Максимальное число: " + max);