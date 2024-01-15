// Напишите программу со статическим методом, которому аргументом передается целочисленный массив и
// целое число. Результатом метод возвращает ссылку на новый массив, который получается из исходного массива
// (переданного первым аргументом методу), если в нем взять не­сколько начальных элементов. Количество элементов,
// которые нужно взять из исходного массива, определяются вторым аргументом метода. Если второй аргумент метода
// больше длины массива, переданного пер­вым аргументом, то методом создается копия исходного массива и
// воз­вращается ссылка на эту копию.

static void fillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-100, 101);
    }
}

static int[] cutArray(int[] array, int cutLenght)
{
    if (cutLenght > array.Length) cutLenght = array.Length;
    int[] newArray = new int[cutLenght];
    for (int i = 0; i < cutLenght; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

static void showArray(int[] array)
{
    Console.Write("Переданный массив выглядит:\n[ " + string.Join(" | ", array) + " ]\n");
}

Console.Write("Введите размер создаваемого массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[arrayLength];
fillArray(nums);
showArray(nums);
Console.Write("\nСколько элементов созданного массива использовать в новом массиве: ");
int newArrayLength = Convert.ToInt32(Console.ReadLine());
showArray(cutArray(nums, newArrayLength));
Console.WriteLine("Изначальный массив теперь выглядит так:");
showArray(nums);