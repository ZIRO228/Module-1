using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя размер массива K и диапазон [A, B)
        Console.Write("Введите размер массива K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите нижнюю границу диапазона A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите верхнюю границу диапазона B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        // Инициализируем массив и объект для генерации случайных чисел
        int[] array = new int[K];
        Random random = new Random();

        // Заполняем массив случайными числами в диапазоне [A, B)
        for (int i = 0; i < K; i++)
        {
            array[i] = random.Next(A, B);
        }

        // Выводим массив на экран
        Console.WriteLine("Массив:");
        Console.WriteLine(string.Join(", ", array));

        // Находим индексы минимального и максимального элементов
        int minIndex = 0;
        int maxIndex = 0;

        for (int i = 1; i < K; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }

            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        // Выводим индексы минимального и максимального элементов
        Console.WriteLine($"\nМинимальный элемент: {array[minIndex]} (индекс {minIndex})");
        Console.WriteLine($"Максимальный элемент: {array[maxIndex]} (индекс {maxIndex})");

        // Определяем, от какого до какого индекса выводить (порядок может быть обратным)
        int start = Math.Min(minIndex, maxIndex);
        int end = Math.Max(minIndex, maxIndex);

        // Выводим элементы между минимальным и максимальным индексами, включая их
        Console.WriteLine("\nЭлементы между минимальным и максимальным:");
        for (int i = start; i <= end; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}