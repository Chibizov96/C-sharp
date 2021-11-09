// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max);
    Console.WriteLine("Массив из " + arr.Length + " элементов: " + String.Join(" ", arr));
    return arr;
}

int[] PairMod(int[] array, int n)
{
    int[] new_array = new int[n / 2];
    int length = array.Length;
    if (length % 2 > 0) --length;
    for (int i = 0; i < length / 2; i++) new_array[i] = array[i] * array[length - i - 1];
    return new_array;
}
int n = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[n];
int[] a = Random(array1, -100, 100);
int[] b = PairMod(a, n);
Console.WriteLine("Произведения попарно: " + String.Join(" ", b));


