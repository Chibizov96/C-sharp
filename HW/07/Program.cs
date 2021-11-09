// Показать числа от -N до N
Console.WriteLine("Введите число N");
int maximum;
maximum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Числа от -N  до N");
int minimum;
minimum = -maximum;

int index;
index = minimum;
while (index <= maximum)
{
    Console.Write(index + " ");
    index++;
}