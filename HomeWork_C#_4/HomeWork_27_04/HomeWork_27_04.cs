/* Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: ");
// Сообщение вводе числа
int originalNumber = int.Parse(Console.ReadLine());
// Проверка на целое число, если успешно, то конвертирует
int conversionNumber = originalNumber;
// Переменная нужна только для финального вывода в консоль
int count = Convert.ToString(originalNumber).Length;
// Длинну числа мы можем узнать только в строковом типе
int MetodSum(int number)
{
int summ = 0;
int result = 0;
    for(int i = 0; i < count; i++)
    {
    result = originalNumber - originalNumber % 10; 
    summ = summ + (originalNumber - result); 
    originalNumber = originalNumber / 10; 
    }
    return summ;
}
// Метод принемает число и выполняет цикл count раз - длина числа
// В теле цикла мы разделяем цифры числа и складываем их через вспомогательные переменные summ и result
int printSumm = MetodSum(originalNumber);
// Объявление метода
Console.WriteLine($"Сумма цифр числа: '{conversionNumber}' -> '{printSumm}'");
// Вывод результата в консоль.

