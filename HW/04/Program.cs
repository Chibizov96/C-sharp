// Найти максимальное из трех чисел
int a = 14;
int b = 12;
int c = 32;
void Method(int first, int second, int third)
{
    int max = first;
    if (first < second) max = second;
    if (max < third) max = third;
    Console.WriteLine("Максимальное число: " + max);
}
Method(a, b, c);