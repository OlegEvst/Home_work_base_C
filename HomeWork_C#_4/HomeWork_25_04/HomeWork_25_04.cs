/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.WriteLine("Введите первое и второе число ','");
// Сообщение ввода двух чисел через запятую
string[] values = Console.ReadLine().Split(new char[] { ',' });
    int firstNumber = int.Parse(values[0]);
    int secondNumber = int.Parse(values[1]);
// Разделяет и переводит в числа введённые строковые значения
int PowNumber(int a, int b)
{       
    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result; 
}
// Метод принемает 2 значения и возвращает значение первоего числа в степени второго.

int printNumber = PowNumber(firstNumber,secondNumber);
// Объявление метода
Console.WriteLine($" {firstNumber}^{secondNumber} -> {printNumber}");
// Вывод результата в консоль.

