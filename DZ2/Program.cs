Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int Digits(int num)
{
    if (num == 0)
        return 1;

    

int result = 0;
    while(num > 0)
    {
        
        num = num / 10;
        result++;
    }
    
    return result;
}
int digit = Digits(num);
Console.WriteLine(digit);