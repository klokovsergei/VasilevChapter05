// Напишите программу со статическим методом, аргументом которо­му передается символьный массив,
// а результатом возвращается ссылка на целочисленный массив, состоящий из кодов символов из массива­ аргумента.

static int[] ConvertFromCharToInt(char[] nums)
{
    int[] numsInt = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
        numsInt[i] = nums[i];
    return numsInt;
    
}

static char[] CreatAndFillCharArr(int size)
{
    char[] arr = new char[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = (char)random.Next('А','я');
    return arr;
}

static void ShowArr(char[] nums)
{
    Console.Write($"[ {string.Join("\t", nums)} ]\n");
}
static void ShowArrInt(int[] nums)
{
    Console.Write($"[ {string.Join("\t", nums)} ]\n");
}

Console.WriteLine("Введите размерность символьного массива: ");
int size = int.Parse(Console.ReadLine()!);

char[] arrayChars = CreatAndFillCharArr(size);
ShowArr(arrayChars);

int[] arrayInt = ConvertFromCharToInt(arrayChars);
ShowArrInt(arrayInt);