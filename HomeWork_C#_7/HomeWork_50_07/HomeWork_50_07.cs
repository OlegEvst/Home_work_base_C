/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

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
            matx[i,j] = new Random().Next(-100,100);
        }
    }
    return matx;
}

int[] SearchIndex(int[,] searchMx)
// Метод получает двумерный массив производит поиск числа и возвражает одномерный массив
{
    Console.WriteLine("Введите число: ");
    int inputNumber = int.Parse(Console.ReadLine());
    int indexI = 0;
    int indexJ = 0;
    int search = 0;
    // Индексы для возврата из метода
    for(int i = 0; i <  searchMx.GetLength(0); i++)
    {
        for(int j = 0; j < searchMx.GetLength(1); j++)
        {
            if (inputNumber == searchMx[i, j]) 
            { 
              indexI = i;
              indexJ = j;
              search = 1; 
              // Если в двумерном массиве будет введённое число, то передадутся значения индексов
              // Можно было использовать в search bool тип, но возникла проблема с конвертацией при возврате из метода
            }
        }  
    }
    return new int[]{indexI, indexJ, search};
    // Возвращаемый одномерный массив с данными
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

int[,] printMatrix = GetArray(matrix);

PrintMatrix(printMatrix);
Console.WriteLine("");

int[] result = SearchIndex(printMatrix);
 
if (result[2] == 1) Console.WriteLine($"Число найдено. Строка: {result[0] + 1} Столбец: {result[1] + 1}");
else Console.WriteLine("Число не найдено");
// Вывод результата в консоль, условие 1[true] 0[false].




           

