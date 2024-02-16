int Hisobkunak(int a)
{
    if (a == 0)
    {
        return 0;
    }
    return 1 + Hisobkunak(a / 10);
}
int a=int.Parse(Console.ReadLine());
Console.WriteLine(Hisobkunak(a));