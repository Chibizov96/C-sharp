// Определить, присутствует ли в заданном массиве, некоторое число 
int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max);
    Console.WriteLine("Базовый массив: " + String.Join(" ", arr));
    return arr;
}
void Search(int[] arr, int number)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
    }
    if (count > 0) Console.WriteLine("Элемент присутствует");
    else Console.WriteLine("Элемент отсутствует");
}
Console.WriteLine("Введите искомый элемент");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[12];
int[] a = Random(array, -100, 100);
Search(a, n);

