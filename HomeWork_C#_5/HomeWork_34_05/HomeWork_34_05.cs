/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размерность числового массива: ");
    int size = int.Parse(Console.ReadLine());
    // Вводим размерность массива
int[] GetArray(int sizeArray)
// Метод, который получает на ввод размер массива и отдаёт заполненный рандомными числами массив
{
    int[] array = new int[size];
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
    }
    return array;
}

void PrintArray(int[] arrPrint)
{
        for(int k = 0; k < arrPrint.Length; k++) 
        {
        if(k == 0) Console.Write($"[{ arrPrint[k]},");
        else if(k !=  arrPrint.Length - 1) Console.Write($"{arrPrint[k]},");
        else Console.Write($"{arrPrint[k]}]");
        }
}

int PositiveNumber(int[] arr)
// Метод, который получает массив и определяет колличетсво чётных чисел в массиве
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    return count;
}

PrintArray(GetArray(size));
    int finalNumber = PositiveNumber(GetArray(size));
        Console.WriteLine("");
            if(finalNumber % 10 == 1 && finalNumber != 11) Console.WriteLine($"В массиве {finalNumber} чётное число.");
            else if (finalNumber > 1 && finalNumber < 5 ) Console.WriteLine($"В массиве {finalNumber} чётных числа.");
            else Console.WriteLine($"В массиве {finalNumber} чётных чисел.");
            // Объявление метода и вывод колличества чётных элементов массива


