/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
Console.WriteLine("Введите размерность массива через 'x'");
    string[] values = Console.ReadLine().Split(new char[] { 'x' });
        int firstNumber = int.Parse(values[0]);
        int secondNumber = int.Parse(values[1]);
         // Вводим размерность двумерного массива
        int[,] matrix = new int[firstNumber,secondNumber];
        // Объявляем массив
int[,] GetArray(int[,] matx)
// Метод получает пустой двумерный массив и заполняет его рандомными числами
{
    for(int i = 0; i < matx.GetLength(0); i++)
    {
        for(int j = 0; j < matx.GetLength(1); j++)
        {
            matx[i,j] = new Random().Next(0,10);
        }
    }
    return matx;
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

void AverageNumber(int[,] average)
// Метод получает двумерный массив и печатает в консоль среднее арифметическое столбцов 
{
    for(int j = 0; j <  average.GetLength(1); j++)
    {
        double result = 0;
        for(int i = 0; i < average.GetLength(0); i++)
        {
             result += average[i, j];
        }
        Console.Write($"{Math.Round(result / average.GetLength(0),2)}. "); 
        }
}

int[,] printMatrix = GetArray(matrix);

PrintMatrix(printMatrix);
    Console.WriteLine("");
AverageNumber(printMatrix);

