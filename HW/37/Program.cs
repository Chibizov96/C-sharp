// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] Random(int[] arr, int min, int max)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(min, max);
    Console.WriteLine("Массив 123 элемента: " + String.Join(" ", arr));
    return arr;
}
int[] NotRandom(int[] arr, int min, int max)
{
    for (int i = 0; i < max - min; i++)
    {
        arr[i] = i + min;
        //Console.WriteLine(arr[i]);
    }
    Console.WriteLine("Массив [10;99]: " + String.Join(" ", arr));
    return arr;
}
int Search(int[] arr1, int[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr1[i] == arr2[j]) count++;
        }
    }
    return count;
}

int[] array1 = new int[123];
int[] array2 = new int[90];
int[] a = Random(array1, -100, 100);
int[] b = NotRandom(array2, 10, 100);
int count = Search(b, a);
Console.WriteLine("Всего вхождений меньшего массива в больший: " + count);
