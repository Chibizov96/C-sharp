// Написать программу замену элементов массива на противоположные
int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
        Console.WriteLine(arr[i]);
    }
    Console.WriteLine("Базовый массив: " + String.Join(" ", arr));
    return arr;
}
int[] Change(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = -arr[i];
    Console.WriteLine("Новый массив: " + String.Join(" ", arr));
    return arr;
}

int[] array = new int[12];

int[] a = Random(array, -100, 100);
Change(a);
