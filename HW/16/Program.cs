// Дано число обозначающее день недели. Выяснить является день недели выходным днём
Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
void Method(int day)
{
    if ((day == 6) || (day == 7)) Console.WriteLine("Выходной день");
    else
    {
        if ((day > 0) && (day < 6)) Console.WriteLine("Рабочий день");
        else Console.WriteLine("Введено неверное число. Введите число от 1 до 7");
    }
}
Method(a);