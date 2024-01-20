// Напишите программу со статическим методом, аргументом которому передается целочисленный массив,
// а результатом возвращается среднее значение для элементов массива (сумма значений элементов,
// деленная на количество элементов в массиве).

static int[] CreatAndFillIntArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(0, 101);
    return arr;
}

static double Average(int[] nums)
{
    int sum = 0;
    foreach (int i in nums)
        sum += i;
    return (double)sum / nums.Length;
}

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] nums = CreatAndFillIntArray(size);
Console.WriteLine($"[ {string.Join(", ", nums)} ]");

Console.WriteLine($"Среднее значение элементов массива = {Average(nums)}");
