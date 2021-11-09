// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число:");
int number;
number = Convert.ToInt32(Console.ReadLine());
Console.Write("Последняя цифра: ");
Console.WriteLine(number % 10);