﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите числа через ','");
// Сообщение ввода двух чисел через запятую
string[] array = Console.ReadLine().Split(new char[] { ',' });
// Вводим через запятую элементы массива - это могут быть, как числа так и символы.
void PrintArray(string[] numberArray)
// Метод, который переберает введёный массив и печатает элементы в консоль через заптую.
    {
    int count = numberArray.Length;
        if(count == 8)
        // Проверка на соответвие условия из 8 элементов
        {
            for(int i = 0; i < count; i++)
            {
                if(i == 0) Console.Write($"[{numberArray[i]},");
                else if(i != count - 1) Console.Write($"{numberArray[i]},");
                else Console.Write($"{numberArray[i]}]");
                // Цикл перебирает каждый элемет массива и в зависимости от значения ставит или не ставит запятую.
            }
        }
        else Console.Write("Введите строго 8 элементов через запятую");
    }

PrintArray(array);
// Вызов метода.