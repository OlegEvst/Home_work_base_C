/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 7 */

Console.WriteLine("Введите числа через ','");
// Сообщение ввода чисел через запятую
double[] inputArray = Array.ConvertAll(Console.ReadLine().Split(new char[] { ',' }), double.Parse);
// Создадим вещественный массив переконвертировав его из строчного типа,чтобы разделить элементы через запятую. 
double[] GetArray(double[] doubleArray)
// Метод получает вещественные числа, возвращает  одномерный массив из вещественных чисел.
{
    for(int i = 0; i < doubleArray.Length; i++)
    {
        if(i == 0) Console.Write($"[{doubleArray[i]},");
        else if(i != doubleArray.Length - 1) Console.Write($"{doubleArray[i]},");
        else Console.Write($"{doubleArray[i]}]");
    }
    return doubleArray;
}

double MaxNumber(double[] doubleFirstArray)
// Метод получает вещественный массив и возвращает максимальное число из массива.
{
    double maximumNumber = doubleFirstArray[0];
        for(int j = 0; j < doubleFirstArray.Length; j++)
            {
                if(doubleFirstArray[j] > maximumNumber) maximumNumber = doubleFirstArray[j];
                // Условие в цикле для определения и присвоения максимального значения массива
            }
            return maximumNumber;
                 
}

double MinNumber(double[] doubleSecondArray)
// Метод получает вещественный массив и возвращает минимальное число из массива.
{
    double minimumNumber = doubleSecondArray[0];
        for(int k = 0; k < doubleSecondArray.Length; k++)
            {
                if(doubleSecondArray[k] < minimumNumber) minimumNumber = doubleSecondArray[k];
                // Условие в цикле для определения и присвоения минимального значения массива
            }
            return minimumNumber;
                 
}

GetArray(inputArray);
    double difference = MaxNumber(inputArray) - MinNumber(inputArray);
    double max = MaxNumber(inputArray);
    double min = MinNumber(inputArray);

Console.WriteLine("");
Console.WriteLine($"Максимальное значение -> {MaxNumber(inputArray)}");
Console.WriteLine($"Минимальное значение -> {MinNumber(inputArray)}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {difference}"); 



