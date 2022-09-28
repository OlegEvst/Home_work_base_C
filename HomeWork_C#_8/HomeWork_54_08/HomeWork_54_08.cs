/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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
            matx[i,j] = new Random().Next(-10,10);
        }
    }
    return matx;
}

int[,] SortArray(int[,] sortMatx)
// Метод получает двумерный массив, сортирует его по строкам от большего к меньшему
// и отдаёт двумерный отсортированный массив.
{
    for(int k = 0; k < sortMatx.GetLength(0); k++)
    {
        for(int i = 0; i < sortMatx.GetLength(1); i++)
        {
            for(int j = sortMatx.GetLength(1) - 1; j > i; j--)
            {
                if(sortMatx[k, j] > sortMatx[k, j - 1]) 
                {
                int temp = sortMatx[k, j];
                sortMatx[k, j] = sortMatx[k, j - 1];
                sortMatx[k, j - 1] = temp;
                }
            }
        }
    }
    return sortMatx;
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
int[,] sortArray = SortArray(firstMatrix);
// Вторичный отсортрованный двумерный массив.
Console.WriteLine("");
PrintMatrix(sortArray);
// Вывод в консоль вторичного отсортированного двумерного массива.