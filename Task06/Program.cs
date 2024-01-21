// Напишите программу со статическим методом, аргументом которому передается двумерный целочисленный массив.
// У метода, кроме аргумен­та-массива, есть два неинициализированных аргумента. Результатом метод возвращает
// значение наибольшего элемента в массиве. Неинициализиро­ванным аргументам присваиваются значения индексов этого элемента.

static int[,] CreatAndFillIntArray(int size0, int size1)
{
    int[,] arr = new int[size0, size1];
    for (int i = 0; i < size0; i++)
        for (int j = 0; j < size1; j++)
            arr[i, j] = new Random().Next(0, 101);
    return arr;
}

static void ShowArr(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {   
        Console.Write("[\t");
        for (int j = 0; j < nums.GetLength(1); j++)
            Console.Write(nums[i, j] + "\t");
        Console.Write("]\n");
    }
}

static int MaxValueArr(int[,] nums, out int index0, out int index1)
{
    int maxValue = nums[0, 0];
    index0 = 0;
    index1 = 0;
    for (int i = 0; i < nums.GetLength(0); i++)
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            if (maxValue < nums[i, j])
            {
                maxValue = nums[i, j];
                index0 = i;
                index1 = j;
            }
        }
    return maxValue;
}

Console.Write("Введите размер двумерного массива [ X ,   ]: ");
int size0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите размер двумерного массива [   , X ]: ");
int size1 = int.Parse(Console.ReadLine()!);
int[,] array = CreatAndFillIntArray(size0, size1);
ShowArr(array);

//выполнение самого задания
int index0, index1;
Console.WriteLine($"Максимальный элемент двумерного массива = {MaxValueArr(array, out index0, out index1)}.");
Console.WriteLine($"Индексы позиции максимального значения [ {index0}, {index1}].");
