/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Clear();
Console.WriteLine("Введите размерность массива через 'x'");
    string[] values = Console.ReadLine().Split(new char[] { 'x' });
        int firstNumber = int.Parse(values[0]);
        int secondNumber = int.Parse(values[1]);
        // Вводим размерность массива
            double[,] matrix = new double[firstNumber,secondNumber];
            // Вещественный массив с задаваемой размерностью
            
double[,] GetMatrix(double[,] matx)
// Метод, который получает на вход вещественный массив, генерирует случайное вещественное число и возвращает массив
{
    for(int i = 0; i < matx.GetLength(0); i++)
    {
        for(int j = 0; j < matx.GetLength(1); j++)
        {
         double convertDouble = (new Random().NextDouble() * 2 - 1) * 10;
         // генерация случайного вещественного числа в диапазоне и чтобы увеличить порядок 10
         matx[i,j] = Math.Round(convertDouble, 2);
         // оставляем 2 знака после запятой
        }    
    }
    return matx;
}

void PrintMatrix(double[,] newMatrix)
// Метод, который печатает массив
{
     for(int k = 0; k < newMatrix.GetLength(0); k++)
    {
        for(int l = 0; l < newMatrix.GetLength(1); l++) 
        {
        Console.Write($"[");
        Console.Write($"{newMatrix[k,l]}, ");
        Console.Write($"\b\b]");   
        }
        Console.WriteLine("");
    }
}

double[,] printMatrix = GetMatrix(matrix);
PrintMatrix(printMatrix);

