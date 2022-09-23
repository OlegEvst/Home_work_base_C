/* Задача 41: Пользователь вводит с клавиатуры M чисел.
 Посчитайте, сколько чисел больше 0 ввёл пользователь */

Console.WriteLine("Введите M чисел через ','");
// Сообщение ввода чисел через запятую
int[] inputNumber = Array.ConvertAll(Console.ReadLine().Split(new char[] { ',' }), int.Parse);
// Создадим числовой массив переконвертировав его из строчного типа,чтобы разделить элементы через запятую. 
int PositiveNumber(int[] intNumber)
// Метод получает числовой массив и возвращает колличество положительных чисел.
{
    int count = 0;
        for(int i = 0; i < intNumber.Length; i++)
        {
            if(intNumber[i] > 0) count++;
            // Условие в цикле для колличества положительных чисел.
        }
        return count;        
}

int finalNumber = PositiveNumber(inputNumber);

Console.WriteLine("");
    if(finalNumber == 1 && finalNumber != 11) Console.WriteLine($"В ведённых числах: {finalNumber} положительное число.");
    else if (finalNumber > 1 && finalNumber < 5 ) Console.WriteLine($"В ведённых числах: {finalNumber} положительных числа.");
    else Console.WriteLine($"В ведённых числах: {finalNumber} чётных чисел.");
