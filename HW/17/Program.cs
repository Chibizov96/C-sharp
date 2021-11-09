// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число:");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int second = Convert.ToInt32(Console.ReadLine());
if ((first * first == second) || (second * second == first)) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("числа не являются квадратами друг друга");