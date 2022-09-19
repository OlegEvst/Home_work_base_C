/* Задача 36: Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов, стоящих
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.WriteLine("Введите размерность числового массива: ");
    int size = int.Parse(Console.ReadLine());
// Вводим размерность массива
int[] GetArray(int sizeArray)
// Метод, который получает на ввод размер массива и отдаёт заполненный рандомными числами массив
{
    int[] array = new int[size];
    for(int i = 0; i< array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
        if(i == 0) Console.Write($"[{array[i]},");
        else if(i != array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}]");
    }
    return array;
}

void AmountNumber(int[] arr)
// Метод, который получает массив и определяет сумму элементов, стоящих на нечётных позициях.
{
    int result = 0;
    // Условный накопитель суммы 
    for(int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0) result += arr[i];
        // Если остаток от деления на 2 индекса позиции не равен 0, то число не чётное.
    }
    Console.WriteLine("");
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {result} ");
}

int[] finalArray = GetArray(size);
AmountNumber(finalArray);
// Объявление метода