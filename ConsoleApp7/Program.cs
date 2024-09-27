using System;

class Program
{
    static void Main()
    {
        // Инициализируем массив из 10 элементов
        int[] array = { 12, 7, 5, 23, 18, 9, 14, 6, 11, 3 };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        Console.WriteLine(string.Join(", ", array));

        // Запрашиваем у пользователя целое число
        Console.Write("Введите целое число для замены максимального элемента: ");
        int newValue = Convert.ToInt32(Console.ReadLine());

        // Находим индекс максимального элемента массива
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        // Заменяем максимальный элемент на новое значение
        array[maxIndex] = newValue;

        // Выводим измененный массив
        Console.WriteLine("Измененный массив:");
        Console.WriteLine(string.Join(", ", array));
    }
}