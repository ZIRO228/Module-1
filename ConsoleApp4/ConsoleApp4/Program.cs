using System;

class Program
{
    static void Main()
    {
        // Инициализируем массив на 20 элементов
        int[] numbers = new int[20];

        // Создаем объект для генерации случайных чисел
        Random random = new Random();

        // Заполняем массив случайными числами от 1 до 100
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        
        // Находим максимальное и минимальное значения в массиве
        int max = numbers[0];
        int min = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
        }

        // Выводим массив на экран
        Console.WriteLine("Массив случайных чисел: " + string.Join(", ", numbers));

        // Выводим максимальное и минимальное значения
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");
    }
}