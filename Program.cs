using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя количество строк
        Console.Write("Введите количество строк: ");
        int n = int.Parse(Console.ReadLine());

        // Создаем массив строк указанного размера
        string[] inputArray = new string[n];

        // Заполняем массив строками, введенными пользователем
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите строку {i + 1}: ");
            inputArray[i] = Console.ReadLine();
        }

        // Создаем новый массив для хранения строк длиной меньше или равной 3 символам
        string[] newArray = FilterArray(inputArray);

        // Выводим новый массив на экран
        Console.WriteLine("Новый массив:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterArray(string[] inputArray)
    {
        // Счетчик для подсчета количества строк, удовлетворяющих условию
        int count = 0;

        // Первый проход для подсчета количества строк, удовлетворяющих условию
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив нужного размера
        string[] newArray = new string[count];

        // Второй проход для заполнения нового массива строками, удовлетворяющими условию
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        return newArray;
    }
}

