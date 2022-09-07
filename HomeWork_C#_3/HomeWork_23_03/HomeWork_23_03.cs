/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Введите число N");
    int inputNumber = int.Parse(Console.ReadLine());
        if(inputNumber !=0)
        {
            for (int i = 1; i <= inputNumber; i++)
                {
                    if(i == 1) Console.Write($"{inputNumber} -> {Math.Pow(i, 3)},");
                    else if (i != inputNumber) Console.Write($"{Math.Pow(i, 3)},");
                    else Console.Write($"{Math.Pow(i, 3)}");
                }
        }