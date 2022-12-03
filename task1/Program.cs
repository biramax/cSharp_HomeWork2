/*

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

*/



// Принимает трёхзначное число.
// Возвращает вторую цифру этого числа.
int DoCalculation(int number) 
{
    int firstDigit = number / 100;      // 456 -> 4
    int hundreds   = firstDigit * 100;  // 4 -> 400
    int tens       = number - hundreds; // 456 - 400 -> 56
    int secondDigit = tens / 10;        // 56 -> 5
    
    return secondDigit;
}



Console.WriteLine("Программа выводит вторую цифру заданного трёхзначного числа.");
Console.Write("Введите трёхзначное число: ");

string input  = Console.ReadLine() ?? "";
string output = "";

if (int.TryParse(input, out int num)) 
{
    if (num < 100 || num > 999)
        output = "Вы ввели не трёхзначное число.";
    
    else
        output = $"Вторая цифра числа: {DoCalculation(num)}";
}
else
    output = "Вы ничего не ввели или ввели не число. Выход из программы.";

Console.WriteLine(output);