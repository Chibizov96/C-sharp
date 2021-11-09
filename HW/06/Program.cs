// Выяснить является ли число чётным
Console.Write("Введите число x: ");
int a = Convert.ToInt32(Console.ReadLine());
void Method(int x)
{
    if (x % 2 == 0) Console.WriteLine("Число четное");
    else { Console.WriteLine("Число нечетное"); }
}
Method(a);
