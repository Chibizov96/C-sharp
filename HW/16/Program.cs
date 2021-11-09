// Дано число обозначающее день недели. Выяснить является день недели выходным днём
Console.WriteLine("Введите номер дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a == 6) || (a == 7)) Console.WriteLine("Выходной день");
else
{
    if ((a > 0) && (a < 6)) Console.WriteLine("Рабочий день");
    else Console.WriteLine("Введено неверное число. Введите число от 1 до 7");
}