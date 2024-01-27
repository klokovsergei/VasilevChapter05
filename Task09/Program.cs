// Напишите программу со статическим методом, аргументом которому передается произвольное
// количество целочисленных аргументов. Резуль­татом метод возвращает массив из двух элементов:
// это значения наиболь­шего и наименьшего значений среди аргументов, переданных методу.

class Program
{
    static int[] MaxAndMinValue(params int[] nums)
    {
        int maxValue = nums[0];
        int minValue = nums[0];
        foreach (int i in nums)
        {
            if (i > maxValue) maxValue = i;
            else if (i < minValue) minValue = i;
        }
        return new int[] {minValue, maxValue};
    }

    static void Main()
    {
        Console.WriteLine($"[Мин и Макс] занчения массива = {string.Join((" и "),MaxAndMinValue(new int[]{1, 7, 9, 10, -4, 2, 21, -10}))}");
    }
}