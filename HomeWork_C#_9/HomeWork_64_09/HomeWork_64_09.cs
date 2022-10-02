/* Задача 64: Задайте значение N. Напишите программу,
которая выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2" */

Console.WriteLine("Введите число N:");
int inputNumber = int.Parse(Console.ReadLine());

void GetNumber(int count, int number)
// Метод получает 2 числа и с использованием рекурсии выводит все чётные числа от N до 1
{
    if (count == number + 1) return;
    if (number % 2 == 0) Console.Write((count != number - 1) ? $"{number}," : $"{number}");
    GetNumber(count, number - 1);
}

Console.Write($"N = {inputNumber} -> ");
GetNumber(1, inputNumber);

