/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();
Console.WriteLine("Введите размерность массива через 'x'");
    string[] values = Console.ReadLine().Split(new char[] { 'x' });
        int firstNumber = int.Parse(values[0]);
        int secondNumber = int.Parse(values[1]);
        int thirdNumber = int.Parse(values[2]);
        
int[,,] GetArray(int[,,] matx)
// Метод получает пустой трёхмерный массив и заполняет его рандомными не повторяющими числами 
{
    for(int i = 0; i < matx.GetLength(0); i++)
    {
        for(int j = 0; j < matx.GetLength(1); j++)
        {
            for(int k = 0; k < matx.GetLength(2); k++)        
            {
                int[] tempArray = new int[100];
                for(int x = 0; x < tempArray.Length; x++)
                {
                    tempArray[x] = new Random().Next(0, 100);
                    int[] sortArray = tempArray.Distinct().ToArray();
                    // Метод удаления дубликатов из массива
                        foreach (int el in sortArray)
                        {
                        matx[i,j,k] = el;
                        // Присвоение каждому элементу трёхмерного массива не повторяющий рандомный элемент из одномерного массива 
                        }
                     
                }                       
            } 
        } 
    }
    return matx;
}
   
void PrintMatrix(int[,,] printMx)
{
     for(int k = 0; k < printMx.GetLength(0); k++)
    {
        Console.Write(" | ");
        for(int l = 0; l < printMx.GetLength(1); l++) 
        {
            for(int m = 0; m < printMx.GetLength(2); m++) 
            {
            Console.Write(printMx[k,l,m] + $"({k},{l},{m}) ");
            }
        }
        Console.WriteLine("| "); 
    }
}


int[,,] matrix = new int[firstNumber,secondNumber,thirdNumber];
// Объявляем трёхмерный массив.
int[,,] firstMatrix = GetArray(matrix);

PrintMatrix(firstMatrix);