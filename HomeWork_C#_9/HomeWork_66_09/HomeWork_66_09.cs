/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Введите число N:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M:");
int secondNumber = int.Parse(Console.ReadLine());

int result = 0;

int SumNumber(int numberOne, int numberSecond)
// Метод получает 2 числа и возвращает сумму натуральных натуральных элементов в промежутке от M до N.
{
    if (numberOne == numberSecond + 1) return 0;
    else return numberOne + SumNumber(numberOne + 1, numberSecond);
}

Console.Write($"M = {firstNumber}; N = {secondNumber} -> "
                   + SumNumber(firstNumber, secondNumber));
