// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max);
    Console.WriteLine("Массив из " + arr.Length + " элементов: " + String.Join(" ", arr));
    return arr;
}

int Sum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) sum += arr[i];
    }
    return sum;
}

int[] array1 = new int[6];
int[] a = Random(array1, -100, 100);
int sum = Sum(a);
Console.WriteLine(sum);

