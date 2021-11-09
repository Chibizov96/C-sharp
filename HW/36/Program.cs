// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max);
    Console.WriteLine("Базовый массив: " + String.Join(" ", arr));
    return arr;
}
void Method(int[] arr)
{
    int even = 0;
    int odd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) even += 1;
    }
    odd = arr.Length - even;
    Console.WriteLine("Четных: " + even);
    Console.WriteLine("Нечетных: " + odd);
}

int[] array = new int[12];
int[] a = Random(array, -100, 100);
Method(a);
