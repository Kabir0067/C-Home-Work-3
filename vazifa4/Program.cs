void Judo(int a)
{
    if (a == 0)
    {
        return;
    }
    Judo(a / 10);
    System.Console.Write(a % 10 + " ");
}
int b=int.Parse(Console.ReadLine());
 Judo (b);