//Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int mod = a;
for (int i = 1; i < b; i++)
{
    mod = mod * a;
}
Console.WriteLine(a + " в степени " + b + " равно: " + mod);
