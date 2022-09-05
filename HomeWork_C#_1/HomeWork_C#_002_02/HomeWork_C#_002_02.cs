// Второй вариант решения задачи 002_01.

/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Введите два числа через ','");

string[] values = Console.ReadLine().Split(new char[] { ',' });
int firstNumber = int.Parse(values[0]);
int secondNumber = int.Parse(values[1]);
    if(values.Length == 2)
    {
        if(firstNumber > secondNumber) 
        {
        Console.WriteLine($"Первое число : {firstNumber} больше чем второе : {secondNumber}");   
        }
        else if (secondNumber > firstNumber)
        {
        Console.WriteLine($"Второе число : {secondNumber} больше чем первое : {firstNumber}");  
        }
        else if (secondNumber == firstNumber)
        {
        Console.WriteLine("Числа равны!");
        }
    }
    else 
        {
        Console.WriteLine("Введите два числа через ','");
        }
    

    
