using System;

class Program
{
    static void Chapana(int a)
    {
        for (int i = a; i >= 0; i--)
        {
            System.Console.Write(i + " ");
        }
        System.Console.WriteLine();
    }

    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        Chapana(b);
    }
}

