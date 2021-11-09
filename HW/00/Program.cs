Console.WriteLine("Введите число:");
int b = Convert.ToInt32(Console.ReadLine());
int Method(int a)
{
    int result = a * a;
    return result;
}
Console.WriteLine(Method(b));