// 1. Задайте массив символов (тип char []).
//    Создайте строку из символов этого массива.

//    Конструктор строки вида string(char []) не использовать.

string concat(char[] mass)
{
    string buf = "";
    for (int i = 0; i < mass.Length; i++) { buf = buf + mass[i]; }

    return buf;
}

char[] charArr = { 'H', 'e', 'l', 'l', 'o' };

string res = concat(charArr);
Console.WriteLine(res);





//Решение от Виктора

using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Запрос элементов массива на ввод от пользователя
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine()!;

        // Разделение введенных элементов на массив строк
        string[] inputArray = input.Split(' ');

        // Создание массива символов на основе введенных элементов
        char[] charArray = new char[inputArray.Length];

        // Преобразование введенных элементов в массив символов
        for (int i = 0; i < inputArray.Length; i++)
        {
            charArray[i] = Convert.ToChar(inputArray[i]);
        }

        // Инициализация пустой строки
        string result = "";

        // Преобразование массива символов в строку
        foreach (char c in charArray)
        {
            result += c;
        }

        // Вывод результата
        Console.WriteLine(result);
    }
}