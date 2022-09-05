/* Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа через ','");

string[] values = Console.ReadLine().Split(new char[] { ',' });
int firstNumber = int.Parse(values[0]);
int secondNumber = int.Parse(values[1]);
int twoNumber = int.Parse(values[2]);

    if(values.Length == 3) 
    {
    int max = firstNumber; 
    string messages = "Первое число";  

    if(secondNumber > max) 
        {
        max = secondNumber; 
        messages = "Второе число";  
        }
    if (twoNumber > max)
        {
        max = twoNumber; 
        messages = "Третье число";    
        }
Console.WriteLine($"{messages} является максимальным и его значение равно: {max}"); 

    }
    else 
    {
         Console.WriteLine("Введите три числа через ','");
    }

