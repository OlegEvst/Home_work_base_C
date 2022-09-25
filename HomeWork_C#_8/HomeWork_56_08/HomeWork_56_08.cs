/* 
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */

Console.Clear();
Console.WriteLine("Введите размерность массива через 'x'");
    string[] values = Console.ReadLine().Split(new char[] { 'x' });
        int firstNumber = int.Parse(values[0]);
        int secondNumber = int.Parse(values[1]);
         // Вводим размерность двумерного массива
int[,] GetArray(int[,] matx)
// Метод получает пустой двумерный массив и заполняет его рандомными числами
{
    for(int i = 0; i < matx.GetLength(0); i++)
    {
        for(int j = 0; j < matx.GetLength(1); j++)
        {
            matx[i,j] = new Random().Next(-100,100);
        }
    }
    return matx;
}

void LineMin(int[,] minLine)
{
    int minIndex = 0;
    int minFirstSum = 0;
    int minTwoSum = 0;
    for(int i = 0; i <minLine.GetLength(1); i++)
    {
        minFirstSum  += minLine[0, i]; 
        // Принимаем за строку с минимальной суммой элементов
    }
        for (int i = 0; i < minLine.GetLength(0); i++)
        {
            for (int j = 0; j < minLine.GetLength(1); j++) minTwoSum += minLine[i, j];
            // Просуммируем все строки в двумерном массиве
                if (minTwoSum < minFirstSum)
                {
                minFirstSum = minTwoSum ;
                minIndex = i;
                }
                // Если сумма строки меньше суммы первой строки, то ее принемаем за минимальную и так пробегаемся по всем [i,j]
                minTwoSum = 0;
                // Обнуляем сумму в конце каждого цикла [i,j]
        }
        Console.Write($"В заданном двумерном массиве {minIndex + 1} строка с наименьшей суммой элементов");
}

void PrintMatrix(int[,] printMx)
// Метод получает двумерный массив и печатает его в консоль
{
     for(int k = 0; k < printMx.GetLength(0); k++)
    {
        for(int l = 0; l < printMx.GetLength(1); l++) 
        {
        Console.Write($"[");
        Console.Write($"{printMx[k,l]}, ");
        Console.Write($"\b\b]");   
        }
        Console.WriteLine("");
    }
}

int[,] matrix = new int[firstNumber,secondNumber];
// Объявляем массив.
int[,] firstMatrix = GetArray(matrix);
// Первичный двумерный массив.
PrintMatrix(firstMatrix);
// Вывод в консоль первичного двумерного массива.
Console.WriteLine("");
LineMin(firstMatrix);
// Вывод в консоль строки с наименьшей суммой элементов.