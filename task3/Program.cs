/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/



// Принимает цифру от 1 до 7.
// Возвращает true, если это цифра 6 или 7.
bool DoCalculation(int number) 
{
    return (number == 6 || number == 7);
}



Console.WriteLine("Программа определяет выходной день по введённой цифре дня недели.");
Console.Write("Введите цифру от 1 до 7: ");

string input  = Console.ReadLine() ?? "";
string output = "";

if (int.TryParse(input, out int num)) 
{
    if (num < 1 || num > 7)
        output = "Число за пределами интервала от 1 до 7.";
    
    else
        output = "День "+(DoCalculation(num) ? "" : "не ")+"выходной.";
}
else
    output = "Вы ничего не ввели или ввели не число. Выход из программы.";

Console.WriteLine(output);