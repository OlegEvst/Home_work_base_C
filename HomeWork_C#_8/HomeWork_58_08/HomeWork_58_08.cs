/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();
Console.WriteLine("Введите размерность матриц через 'x'");
    string[] values = Console.ReadLine().Split(new char[] { 'x' });
        int firstNumber = int.Parse(values[0]);
        int secondNumber = int.Parse(values[1]);
         // Вводим размерность двумерного массива

int[,] GetMatrix_A(int[,] matx_A)
// Метод получает пустой двумерный массив и заполняет его рандомными числами
{
    for(int i = 0; i < matx_A.GetLength(0); i++)
    {
        for(int j = 0; j < matx_A.GetLength(1); j++)
        {
            matx_A[i,j] = new Random().Next(1,9);
        }
    }
    return matx_A;
}

int[,] GetMatrix_B(int[,] matx_B)
// Метод получает пустой двумерный массив и заполняет его рандомными числами
{
    for(int i = 0; i < matx_B.GetLength(0); i++)
    {
        for(int j = 0; j < matx_B.GetLength(1); j++)
        {
            matx_B[i,j] = new Random().Next(1,9);
        }
    }
    return matx_B;
}

void PrintDoubleMatrix(int[,] printMx_A, int[,] printMx_B )
// Метод получает две матрицы и печатает его в консоль
{
    int row_1_Count = printMx_A.GetLength(0); // строка в первой матрице
    int rowMedium = printMx_A.GetLength(0) / 2; // Средняя строка
    int col_1_Count = printMx_A.GetLength(1); // Колонок в первой матрице
    int col_2_Count = printMx_B.GetLength(1);// Колонок во второй матрице
 
    for (int k = 0; k < row_1_Count; k++)
    {
        Console.Write(" | ");
        for (int l = 0; l < col_1_Count; l++)
            Console.Write(printMx_A[k, l] + " ");
            Console.Write((k == rowMedium) ? "| * | " : "|   | ");
        for (int l = 0; l < col_2_Count; l++)
            Console.Write(printMx_B[k, l] + " ");
            Console.WriteLine("| ");
    }
}

int[,] GetDoubleMatrix(int[,] getMx_A, int[,] getMx_B)
// Метод получает 2 двумерных массива, переумножает поэлементно и возвращает двумерный результирующий массив
{
    int row_Matrix = getMx_A.GetLength(0); 
    int col_Matrix = getMx_B.GetLength(1);

    int[,] resMass = new int[row_Matrix,col_Matrix];
            for (int r = 0; r < row_Matrix; r++)
                for (int s = 0; s < col_Matrix; s++)
                    for (int t = 0; t < col_Matrix; t++)
                        resMass[r, s] += getMx_A[r, t] * getMx_B[t, s];
            return resMass;
}

void PrintMatrix(int[,] printResult)
// Метод получает двумерный массив и печатает его в консоль
{
    for(int o = 0; o < printResult.GetLength(0); o++)
    {
        Console.Write(" | ");
        for(int p = 0; p < printResult.GetLength(1); p++) 
        {
        Console.Write(printResult[o, p] + " ");
        }
        Console.WriteLine("|");
    }
}

int[,] matrix_A = new int[firstNumber,secondNumber];
int[,] matrix_B = new int[firstNumber,secondNumber];

int[,] firstMatrix = GetMatrix_A(matrix_A);
int[,] secondMatrix = GetMatrix_B(matrix_B);

int[,] dubleMatrix = GetDoubleMatrix(firstMatrix,secondMatrix);

PrintDoubleMatrix(firstMatrix,secondMatrix);
Console.WriteLine("");
PrintMatrix(dubleMatrix);



