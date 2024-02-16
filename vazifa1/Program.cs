using System;

class Program
{
    static void Afzoish(int a)
    {
        for (int i = 1; i <= a; i++)
        {
            System.Console.Write(i + " ");
        }
        
    }

    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        Afzoish(b);
    }
}
