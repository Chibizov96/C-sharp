// Ввести номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти: ");
int quater_num = Convert.ToInt32(Console.ReadLine());
void Square(int quater)
{
    if (quater < 1 | quater > 4) Console.WriteLine("Существует всего 4 четверти :) Введите число от 1 до 4");
    if (quater == 1) Console.WriteLine("x > 0 & y > 0");
    if (quater == 2) Console.WriteLine("x < 0 & y > 0");
    if (quater == 3) Console.WriteLine("x < 0 & y < 0");
    if (quater == 4) Console.WriteLine("x > 0 & y < 0");
}
Square(quater_num);