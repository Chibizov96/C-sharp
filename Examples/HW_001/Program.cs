// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. Создать на его основе масив B, отбрасывая те, которые

// нарушают порядок возрастания
// больше среднего арифметического элементов A
// чётные
// Задача
// Cформировать случайным образом целочисленный массив A
// из натуральных двузначных чисел.

// Создать на его основе масив B, отбрасывая те, которые
// 1  нарушают порядок возрастания
// 2  больше среднего арифметического элементов A
// 3  чётные


// Задать массив



int index = 0;

int[] array = new int[10];
// Заполняет массив
while (index < 10)
{
    array[index] = new Random().Next(10, 100); // [10, 99]
    index++;
}

index = 0;
// печатаем массив

while (index <= 9)
{
    int val = array[index];
    Console.WriteLine(index + 1 + "й элемент: " + val);
    index++;
}

Console.WriteLine();
index = 1;
// Исключение элементов нарушения возрастания
// int currentElement = array[0];
// Console.WriteLine(currentElement);
// while (index <= 9)
// {
//     if (array[index] > currentElement)
//     {
//         Console.WriteLine(array[index]);
//         currentElement = array[index];
//     }
//     index++;
// }

// Задача 2
int middle_arifmetic = 0;
int sum = 0;
// определяем среднее арифметическое
while (index <= 9)
{
    sum += array[index];
    index++;
}
Console.WriteLine("Сумма равна: " + sum);
middle_arifmetic = sum / 10;
Console.WriteLine();
Console.WriteLine("Среднее арифметическое: " + middle_arifmetic);

// решаем задачу 2
index = 0;
Console.WriteLine("Элементы массива, которые больше среднего арифметического: ");
while (index <= 9)
{
    if (array[index] > middle_arifmetic)
        Console.Write(array[index] + " ");
    index++;
}
Console.WriteLine();
// Решаем задачу 3
Console.WriteLine("Четные элементы массива: ");
index = 0;
while (index <= 9)
{
    if (array[index] % 2 == 0)
    {
        Console.Write(array[index] + " ");
    }
    index++;
}
Console.WriteLine();