/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

Console.WriteLine("Введите число m:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n:");
int secondNumber = int.Parse(Console.ReadLine());

int FunctionAkkerman(int numberOne, int numberSecond)
{
    if (numberOne == 0) return numberSecond + 1;
    else if (numberOne > 0  && numberSecond == 0) return FunctionAkkerman(numberOne - 1, 1);
    else return (FunctionAkkerman(numberOne - 1, FunctionAkkerman(numberOne, numberSecond - 1)));
}

Console.Write($"m = {firstNumber}; n = {secondNumber} -> "
              + $"A({firstNumber},{secondNumber}) = {FunctionAkkerman(firstNumber, secondNumber)}");
