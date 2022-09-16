//адайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

using System;

class Programm
{
    static void SumNumb(int m, int n)
    {
        int sum = m;
        for (int i = m; i < n; i++)
        {
            sum = sum + i+1;
        }
        Console.Write(sum + " - cумма чисел от m до n.");
    }

    static void Main(string[] args)
    {
        Console.Write("m = ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        SumNumb(m, n);
    }
}