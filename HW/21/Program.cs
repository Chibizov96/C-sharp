// Программа проверяет пятизначное число на палиндромом.
Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine();
string Palindrom(string text_number)
{
    string message = string.Empty;
    if (Convert.ToInt32(text_number) < 10000 | Convert.ToInt32(text_number) > 99999) message = "Число не пятизначное";
    else
    {
        string reverse_number = string.Empty;
        for (int i = text_number.Length - 1; i >= 0; --i) reverse_number += text_number[i];
        if (text_number == reverse_number) message = "Число является палиндромом";
        else message = "Число не является палиндромом";
    }
    return message;
}
Console.WriteLine(Palindrom(number));