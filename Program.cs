// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

using System;

class Program
{
    static void numbers(int m, int n) 
    {
        Console.WriteLine(m);
        if (m < n) 
        {
            numbers(m + 1, n);
        }
    }
    
    static int Prompt(string Word) 
    {
        Console.WriteLine(Word);
        return int.Parse(Console.ReadLine());
    }
    
    static void Main() 
    {
        int m = Prompt("Введите первое число");
        int n = Prompt("Введите второе число");
        numbers(m, n);
    }
}