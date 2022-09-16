//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N

using System;

class Programm
{
    static void PrintNumb(int m, int n)
    {
        for (int i = m; i < n; i++)
        {
            Console.Write(m + ", ");
            m++;
        }
        Console.Write(n + ". Все числа от m до n.");
    }

    static void Main(string[] args)
    {
        Console.Write("m = ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintNumb(m, n);
    }
}