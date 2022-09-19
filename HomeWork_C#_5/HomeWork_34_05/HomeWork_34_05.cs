/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве.
[345, 897, 568, 234] -> 2 */

Console.WriteLine("Введите размерность числового массива: ");
    int size = int.Parse(Console.ReadLine());
// Вводим размерность массива
int[] GetArray(int sizeArray)
// Метод, который получает на ввод размер массива и отдаёт заполненный  рандомными 3-ёх значными числами массив
{
    int[] array = new int[size];
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
        if(i == 0) Console.Write($"[{array[i]},");
        else if(i != array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}]");
    }
    return array;
}

void PositiveNumber(int[] arr)
// Метод, который получает массив и определяет колличетсво чётных чисел в массиве
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count++;
    }
    Console.WriteLine("");
    if(count % 10 == 1 && count != 11) Console.WriteLine($"В массиве {count} чётное число.");
    else if (count > 1 && count < 5 ) Console.WriteLine($"В массиве {count} чётных числа.");
    else Console.WriteLine($"В массиве {count} чётных чисел.");
    // Перебор правильных склонений окончаний
}

int[] finalArray = GetArray(size);
PositiveNumber(finalArray);
// Объявление метода

