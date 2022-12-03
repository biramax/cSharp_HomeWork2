/*

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6

*/



// Принимает трёх и более значное число.
// Возвращает третью цифру этого числа.
int DoCalculation(int number) 
{
    while (number > 999) // 32679 -> 326
        number = number / 10;
    
    int lastDigit = number % 10; // 326 -> 6
    
    return lastDigit;
}



Console.WriteLine("Программа выводит третью цифру заданного числа");
Console.Write("Введите число: ");

string input  = Console.ReadLine() ?? "";
string output = "";

if (int.TryParse(input, out int num)) 
{
    if (num < 100)
        output = "Третьей цифры в числе нет.";
    
    else
        output = $"Третья цифра числа: {DoCalculation(num)}";
}
else
    output = "Вы ничего не ввели или ввели не число. Выход из программы.";

Console.WriteLine(output);