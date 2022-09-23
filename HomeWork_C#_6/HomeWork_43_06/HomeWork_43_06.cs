/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
 b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.WriteLine("Введите координату b1: ");
    double oneNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату k1: ");
    double twoNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату b2: ");
    double treeNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату k2: ");
    double fourNumber = double.Parse(Console.ReadLine());


double[] GetNumber(double b1, double b2, double k1, double k2)
{
    double x = 0;
    double y = 0;
    if(b1 == k1) Console.WriteLine("Прямые c данными значениями паралельны");
    else 
    {
    x = (b2 - b1)/(k1 - k2);
    y = (k1 * (b2 - b1))/(k1 - k2) + b1;
    }
    return new double[]{x, y};
}

double[] result = GetNumber(oneNumber, twoNumber, treeNumber, fourNumber);

Console.WriteLine($"Х: {result[0]:0.00}");
Console.WriteLine($"Y: {result[1]:0.00}");




