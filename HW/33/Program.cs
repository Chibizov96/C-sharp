// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void Random(int[] arr, int min, int max)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        Console.WriteLine(arr[i]);
        sum += arr[i];
    }
    Console.WriteLine("Сумма равна: " + sum);
}
int[] array = new int[12];
Random(array, 0, 10);
