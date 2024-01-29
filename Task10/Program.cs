// Напишите программу со статическим методом, которому передается текст и произвольное количество
// символьных аргументов. Результатом возвращается текст, который получается добавлением в конец
// исходно­го текста (первый аргумент метода) символьных значений, переданных аргументами методу.

static string ConcatString(string str, params char[] args)
{
    foreach (char i in args)
    {
        str += i;
    }
    return str;
}

string newStr = ConcatString("Hello W", 'o', 'r', 'l', 'd', '!');
Console.WriteLine(newStr);