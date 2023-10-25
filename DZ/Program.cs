Console.WriteLine("Введите число!");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2!");
int num1 = Convert.ToInt32(Console.ReadLine());
int Proba(int num, int num1)
{
    if(num1 > 0)
    {
        double pow = Math.Pow(num, num1);
        int otv = Convert.ToInt32(pow);
        return otv;
    }
    else
    {
        Console.WriteLine("Введите число 2, которое больше нуля!");
        return 0;
    }
}
int got = Proba(num, num1);
Console.WriteLine(got);

