using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя количество простых чисел K
        Console.Write("Введите количество простых чисел K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        // Инициализируем переменные
        int count = 0;  // Количество найденных простых чисел
        int number = 2; // Число, которое будем проверять на простоту

        // Пока не найдем K простых чисел
        while (count < K)
        {
            if (IsPrime(number))
            {
                Console.Write(number + "\t");
                count++;

                // Если нашли 10 чисел в строке, переводим на новую строку
                if (count % 10 == 0)
                {
                    Console.WriteLine();
                }
            }

            // Проверяем следующее число
            number++;
        }
    }

    // Метод для проверки, является ли число простым
    static bool IsPrime(int num)
    {
        if (num < 2) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}