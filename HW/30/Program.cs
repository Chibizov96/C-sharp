// Показать кубы чисел, заканчивающихся на четную цифру
// Кубы 2 , 4 , 8 , 192 , 256
Console.WriteLine("Введите последнее число в ряду, число N");
int x = Convert.ToInt32(Console.ReadLine());
void Method(int n)
{
    for (int i = 1; i < n + 1; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine("Куб числа " + i + " равен: " + i * i * i);
        }
    }
}
Method(x);
