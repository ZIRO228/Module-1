using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Инициализируем массив из 10 элементов
        double[] array = new double[10];
        Random random = new Random();

        // Заполняем массив случайными вещественными числами из диапазона [-10, 10)
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.NextDouble() * 20 - 10; // Генерация числа от -10 до 10
        }

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(", ", array.Select(x => x.ToString("F2")))); // Вывод с округлением до 2 знаков

        // Формируем массив индексов, сортируя их по значениям массива
        int[] indexArray = array
            .Select((value, index) => new { Value = value, Index = index }) // Создаем пары {Значение, Индекс}
            .OrderBy(pair => pair.Value)                                    // Сортируем по значению
            .Select(pair => pair.Index)                                     // Извлекаем индексы
            .ToArray();

        // Выводим массив индексов
        Console.WriteLine("\nМассив индексов элементов в порядке возрастания значений:");
        Console.WriteLine(string.Join(", ", indexArray));
    }
}