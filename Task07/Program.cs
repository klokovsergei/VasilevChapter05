// Напишите программу со статическим методом, аргументом которому передается
// одномерный символьный массив. В результате вызова мето­да элементы массива
// попарно меняются местами: первый - с послед­ним, второй - с предпоследним и так далее.
Console.Clear();

static char[] CreatAndFillCharArr(int size)
{
    char[] chars = new char[size];
    Random random = new Random();
    for (int i = 0; i < chars.Length; i++)
    {
        chars[i] = (char)random.Next((int)'A', (int)'z');
    }
    return chars;
}

static void ReversChars(char[] chars)
{
    char tampChar;
    int sizeArr = chars.Length;
    for (int i = 0; i < sizeArr / 2; i++)
    {
        tampChar = chars[i];
        chars[i] = chars[sizeArr - 1 - i];
        chars[sizeArr - 1 - i] = tampChar;
    }
}

static void ShowArrChars(char[] chars)
{
    Console.WriteLine($"Символьный массив: [ {string.Join(", ", chars)} ]");
}

Console.Write("Введите размер одномерного массива: ");
int size = int.Parse(Console.ReadLine()!);
char[] charsArr = CreatAndFillCharArr(size);
ShowArrChars(charsArr);
Console.WriteLine(" Перевернем массив!");
ReversChars(charsArr);
ShowArrChars(charsArr);
