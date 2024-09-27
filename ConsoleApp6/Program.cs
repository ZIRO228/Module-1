using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя размер массива
        Console.Write("Введите размер массива N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        // Инициализируем массив
        double[] array = new double[N];

        // Ввод элементов массива
        Console.WriteLine($"Введите {N} элементов массива:");
        for (int i = 0; i < N; i++)
        {
            array[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Находим максимальный по модулю элемент массива
        double maxAbsValue = Math.Abs(array[0]);
        for (int i = 1; i < N; i++)
        {
            if (Math.Abs(array[i]) > maxAbsValue)
            {
                maxAbsValue = Math.Abs(array[i]);
            }
        }

        // Нормируем элементы массива
        for (int i = 0; i < N; i++)
        {
            array[i] /= maxAbsValue;
        }

        // Выводим измененный массив
        Console.WriteLine("Нормированные элементы массива:");
        foreach (double element in array)
        {
            Console.WriteLine(element);
        }
    }
}