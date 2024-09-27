using System;

class Program
{
    static void Main()
    {
        // Русский алфавит
        char[] russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя".ToCharArray();

        // Согласные буквы русского алфавита
        char[] consonants = "бвгджзйклмнпрстфхцчшщ".ToCharArray();

        // Запрашиваем у пользователя размер массива K
        Console.Write("Введите размер массива K: ");
        int K = Convert.ToInt32(Console.ReadLine());

        // Инициализируем массивы
        char[] array = new char[K];
        char[] consonantArray;
        Random random = new Random();

        // Заполняем массив случайными буквами русского алфавита
        for (int i = 0; i < K; i++)
        {
            array[i] = russianAlphabet[random.Next(russianAlphabet.Length)];
        }

        // Выводим первый массив (все буквы)
        Console.WriteLine("\nИсходный массив букв:");
        Console.WriteLine(string.Join(", ", array));

        // Создаем список для согласных букв
        var consonantList = new System.Collections.Generic.List<char>();

        // Находим согласные буквы и добавляем их в список
        foreach (char letter in array)
        {
            if (Array.Exists(consonants, consonant => consonant == letter))
            {
                consonantList.Add(letter);
            }
        }

        // Преобразуем список согласных в массив
        consonantArray = consonantList.ToArray();

        // Выводим массив с согласными буквами
        Console.WriteLine("\nМассив согласных букв:");
        if (consonantArray.Length > 0)
        {
            Console.WriteLine(string.Join(", ", consonantArray));
        }
        else
        {
            Console.WriteLine("Согласные буквы отсутствуют.");
        }
    }
}