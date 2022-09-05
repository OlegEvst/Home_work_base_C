/* Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число от 1 до 7");
// Запрашиваем ввод целого числа от 1 до 7
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    // Если при вводе число, то присваиваем его в переменную inputNumber
        if(inputNumber >= 1 && inputNumber <= 7)
        // Если число в диапазоне от 1 до 7 включительно, то переходим к оператору switch
        {
            switch (inputNumber)
            {
            case 6: 
                Console.WriteLine($"{inputNumber} -> выходной день");
            break;

            case 7: 
                Console.WriteLine($"{inputNumber} -> выходной день");
            break;

            default:
                Console.WriteLine($"{inputNumber} -> рабочий день");
            break;
            }
            // Перебираем числа, если 6 иили 7, то выходной день по дефолту рабочий.
        }
        else
        {
        Console.WriteLine($"Не корректный ввод, введите число от 1 до 7"); 
        }