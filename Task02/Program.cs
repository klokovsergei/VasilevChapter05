// Напишите программу со статическим методом, которым вычисляется сумма квадратов
// натуральных чисел 1^2 + 2^2 + 3^2 + ... + n^2. Число n передается аргументом методу.
// Предложите версию метода с рекурсией и без рекурени. Для проверки результата можно
// использовать формулу 1^2 + 2^2 + 3^2 + ... + n^2 = (n * (n + 1) * (2 * n + 1)) / 6

static int sumSquareRecursion(int n)
{
    if (n == 1) return 1;
    else
    {
        return n * n + sumSquareRecursion(n - 1);
    }
}

static int sumSquare(int n)
{
    return (n * (n + 1) * (2 * n + 1)) / 6;
}

static void show(int n)
{
    Console.WriteLine($"Сумма квадратов {n} натуральных числен = {sumSquare(n)}.");
}

static void showRecursion(int n)
{
    Console.WriteLine($"Сумма квадратов {n} натуральных числен с помощью рекурсии = {sumSquareRecursion(n)}.");
}

show(1);
showRecursion(1);
show(2);
showRecursion(2);
show(3);
showRecursion(3);
show(4);
showRecursion(4);
show(5);
showRecursion(5);