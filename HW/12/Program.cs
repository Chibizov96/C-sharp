// Удалить вторую цифру трёхзначного числа
int num = new Random().Next(100, 1000);
void Method(int number)
{
    Console.Write("Рандомное число с отрезка: ");
    Console.WriteLine(number);
    int newnumber = number / 100 * 10 + number % 10;
    Console.WriteLine(newnumber);
}
Method(num);