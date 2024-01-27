// Напишите программу с перегруженным статическим методом. Если аргументом методу передается два целых числа,
// то результатом возвра­щается ссылка на целочисленный массив, состоящий из натуральных чисел, а первое и
// последнее число в массиве определяется аргументами метода. Например, если передать аргументами числа 2 и 4 ,
// то результа­том будет массив из чисел 2 , 3 и 4 . Если аргументами методу передаются два символьных значения,
// то результатом возвращается ссылка на мас­сив, состоящий из последовательности символов, а первый и
// последний символы определяются аргументами метода. Например, если передать аргументами методу символы
// ' В ' и ' D ' , то в результате получим мас­сив из символов 'В', 'С' и 'D'.

static char[] CreatArr(char firstChar, char secondChar)
{
    if ((int)firstChar > (int)secondChar)
    {
        Console.WriteLine("Вы ошиблись последовательность цифр, поэтому я поменял их местами.");
        char temp = firstChar;
        firstChar = secondChar;
        secondChar = temp;
    }
    int sizeArr = (int)secondChar - (int)firstChar + 1;
    char[] nums = new char[sizeArr];
    for (int i = 0; i < sizeArr; i++, firstChar++) nums[i] = firstChar;
    return nums;
}

static int[] CreatArr(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        Console.WriteLine("Вы ошиблись последовательность цифр, поэтому я поменял их местами.");
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
    }
    int sizeArr = secondNumber - firstNumber + 1;
    int[] nums = new int[sizeArr];
    for (int i = 0; i < sizeArr; i++, firstNumber++) nums[i] = firstNumber;
    return nums;
}

static void ShowArr(int[] nums)
{
    Console.WriteLine($"Массив выглядит: [ {string.Join(", ", nums)} ]");
}

static void ShowArr(char[] nums)
{
    //Console.WriteLine($"Массив выглядит: [ {string.Join(", ", nums)} ]");
    Console.WriteLine(nums);
}

int firstNumber_ = new Random().Next(0,11);
int secondNumber_ = new Random().Next(0,11);
int[] numbers = CreatArr(firstNumber_, secondNumber_);
ShowArr(numbers);

// firstNumber_ = new Random().Next((int)'А',(int)'я');
// secondNumber_ = new Random().Next((int)'А',(int)'я');

// char firstChar = (char)firstNumber;
// char secondChar = (char)secondNumber;
char firstChar_ = 'A';
char secondChar_ = 'k';
char[] chars = CreatArr(firstChar_, secondChar_);
ShowArr(chars);

