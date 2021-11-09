// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число:");
int number;
number = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая цифра: ");
Console.WriteLine(number % 100 / 10);