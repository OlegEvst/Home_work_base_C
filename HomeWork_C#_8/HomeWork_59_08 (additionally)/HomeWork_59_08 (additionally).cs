/* Задача 59: Задайтедвумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7 */

Console.Clear();
Console.WriteLine("Введите размерность массива, через 'x'");

string[] values = Console.ReadLine().Split(new char[] { 'x' });
        int firstNumber = int.Parse(values[0]);
        int secondNumber = int.Parse(values[1]);

int[,] GetArray(int[,] inputArray)
{
    for(int i = 0; i < inputArray.GetLength(0); i++)
    {
        for(int j = 0; j < inputArray.GetLength(1); j++)
        {
            inputArray[i,j] = new Random().Next(0,10);
        }
    }
    return inputArray;
}

int[,] DeleteArray(int[,] deleteArray)
{   
            int minValue = deleteArray[0, 0];
            int minIndex = 0;
            for (int a = 1; a < deleteArray.GetLength(0); a++)
            {
            if (deleteArray[a, a] < minValue)
                {
                minValue = deleteArray[a, a];
                minIndex = a;
                }
            }
    int[,] newArray = new int[deleteArray.GetLength(0) - 1, deleteArray.GetLength(1) - 1];

        for (int i = 0; i < deleteArray.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < deleteArray.GetLength(1) - 1; j++)
            {
                if (i < minIndex && j < minIndex)
                        newArray[i, j] = deleteArray[i, j];
                if (i >= minIndex && j < minIndex)
                        newArray[i, j] = deleteArray[i + 1, j];
                if (i < minIndex && j > minIndex)
                        newArray[i, j] = deleteArray[i, j + 1];
                if (i >= minIndex && j > minIndex)
                        newArray[i, j] = deleteArray[i + 1, j + 1];
            }
        }
        return newArray;
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
int[,] deleteMatrix = DeleteArray(firstMatrix);
Console.WriteLine();
PrintMatrix(deleteMatrix);