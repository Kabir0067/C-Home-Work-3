
using System;

class Program
{
    static int Sum(int a)
    {
        int sum = 0;
        for (int i = 0; i <= a; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Sum(b));
    }
}
