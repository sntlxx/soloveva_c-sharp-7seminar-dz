void Main()
{
int m = ReadInt("Введите число m: ");
int n = ReadInt("Введите число n: ");
Console.WriteLine($"Результат: {Akkerman(m, n)}");

}

int Akkerman(int m, int n)
{
    if (m ==0)
        return (n + 1);
    else if (m > 0 && n==0)
        return Akkerman(m-1,1);
    else
        return Akkerman(m-1, Akkerman(m, n-1));

}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
