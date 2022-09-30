/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int[,] GetArray(int[,] matx)
// Метод получает пустой двумерный 4x4 массив и заполняет его по спирали
{
    int count = 1;
    int value = matx.GetLength(0);
    for(int i = 0; i < value; i++)
    {
        for(int j = 0; j < value; j++)
        {
            int x = 0;
            for( x = 0; x < value - 1; x++) matx[i, j++] = count++;
            for( x = 0; x < value - 1; x++) matx[i++, j] = count++;
            for( x = 0; x < value - 1; x++) matx[i, j--] = count++; 
            for( x = 0; x < value - 1; x++) matx[i--, j] = count++; 
            for( x = 2; x < value - 1; x++) matx[++i, ++j] = count++;
            for( x = 2; x < value - 1; x++) matx[i, ++j] = count++;
            for( x = 1; x < value - 1; x++) matx[1+i, j--] = count++;
            value = value < 2 ? value - 2 : 0;    
        }
    }  
    return matx;
}

void PrintMatrix(int[,] printResult)
// Метод получает двумерный массив и печатает его в консоль и добавляет 0
{
    for(int i = 0; i < printResult.GetLength(0); i++)
    {
        Console.Write(" | ");
        for(int j = 0; j < printResult.GetLength(1); j++) 
        {
        Console.Write((printResult[i, j] < 10) ? $"{0}{printResult[i, j]}" + ' ' : $"{printResult[i, j]}" + " ");
        }
        Console.WriteLine("|");
    }
} 

int[,] firstArray= GetArray(new int[4,4]);

PrintMatrix(firstArray);
Console.WriteLine("");
