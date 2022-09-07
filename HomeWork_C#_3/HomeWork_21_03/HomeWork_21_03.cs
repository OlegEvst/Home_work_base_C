/* Задача 21 Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты первой точки, через запятую");
    string[] values = Console.ReadLine().Split(',');

        if(values.Length != 3) Console.WriteLine("Не корректный ввод координат точки");
            int x1 = int.Parse(values[0]);
            int y1 = int.Parse(values[1]);
            int z1 = int.Parse(values[2]);

Console.WriteLine("Введите координаты второй точки, через запятую");
    string[] values_2 = Console.ReadLine().Split(','); 

        if(values_2.Length != 3) Console.WriteLine("Не корректный ввод координат точки");
            int x2 = int.Parse(values_2[0]);
            int y2 = int.Parse(values_2[1]);
            int z2 = int.Parse(values_2[2]);
    
    double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

Console.WriteLine($"Расстояние между двумя точками в 3D равно: {result}");
