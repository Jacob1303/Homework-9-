//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

using System;

class Programm
{
    static int AkkermanFunc(int m, int n)
    {
        if (m == 0) return n + 1;
        else
        {
            if (n == 0) return AkkermanFunc(m - 1, 1);
            else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        Console.Write("m = ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(AkkermanFunc(m, n));
    }
}