//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] Random(double[] arr, int n)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().NextDouble() * n;
    Console.WriteLine("Массив из " + arr.Length + " элементов: " + String.Join(" ", arr));
    return arr;
}
double Max(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
double Min(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; ++i)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}
Console.Write("Введите число элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число знаков после запятой ");
int focus = Convert.ToInt32(Console.ReadLine());
double[] array1 = new double[n];
double[] a = Random(array1, n);
double max = Math.Round(Max(a), focus);
double min = Math.Round(Min(a), focus);
Console.WriteLine("Разница между максимальным и минимальным ~" + Math.Round(max - min, focus));