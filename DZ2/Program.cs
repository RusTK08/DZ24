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


int Sum(int num, int digit)
{
int sum = 0;
for (int i = 1; i <= digit; i++)
{
sum += num % 10; //складываем остатки
num /= 10;
}
return sum;
}
Console.Write($"Сумма равна: {Sum(num,digit)}");
