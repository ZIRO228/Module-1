using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Определяем размер квадратной матрицы
        int N = 5; // Размер матрицы 5x5
        int[,] matrix = new int[N, N]; // Создаем двумерный массив для матрицы
        Random rand = new Random(); // Объект для генерации случайных чисел

        // Заполняем матрицу случайными числами в диапазоне [-50, 50]
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                matrix[i, j] = rand.Next(-50, 51); // Генерация случайного числа
            }
        }

        // Выводим исходную матрицу
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix);

        // Сортируем строки матрицы по сумме элементов в каждой строке
        var orderedMatrix = matrix.Cast<int>() // Преобразуем матрицу в одномерный массив (flatten)
            .Select((value, index) => new { value, row = index / N }) // Определяем значения и строки
            .GroupBy(item => item.row) // Группируем элементы по строкам
            .OrderBy(g => g.Sum(item => item.value)) // Сортируем строки по сумме значений
            .SelectMany(g => g.Select(item => item.value)) // Собираем отсортированные значения в одномерный массив
            .ToArray();

        // Выводим отсортированную матрицу
        Console.WriteLine("Отсортированная матрица:");
        PrintMatrix(To2DArray(orderedMatrix, N, N)); // Преобразуем одномерный массив обратно в двумерный и выводим
    }

    // Метод для преобразования одномерного массива в двумерный
    static int[,] To2DArray(int[] flatArray, int rows, int cols)
    {
        int[,] array = new int[rows, cols]; // Создаем двумерный массив
        for (int i = 0; i < flatArray.Length; i++) // Проходим по элементам одномерного массива
        {
            array[i / cols, i % cols] = flatArray[i]; // Раскладываем элементы по строкам и столбцам
        }
        return array;
    }

    // Метод для печати матрицы на экран
    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) // Проходим по строкам
        {
            for (int j = 0; j < matrix.GetLength(1); j++) // Проходим по столбцам
            {
                Console.Write(matrix[i, j] + "\t"); // Выводим элемент с табуляцией для удобства
            }
            Console.WriteLine(); // Переход на новую строку после каждой строки матрицы
        }
    }
}