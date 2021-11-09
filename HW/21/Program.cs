// Программа проверяет пятизначное число на палиндромом.
Console.Write("Введите пятизначное число: ");
string text_number = Console.ReadLine();
if (Convert.ToInt32(text_number) < 10000 | Convert.ToInt32(text_number) > 99999) Console.WriteLine("Число не пятизначное");
else
{
    string reverse_number = string.Empty;
    for (int i = text_number.Length - 1; i >= 0; --i) reverse_number += text_number[i];
    if (text_number == reverse_number) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}