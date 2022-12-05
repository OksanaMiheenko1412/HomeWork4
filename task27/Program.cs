// task27 программа принимает на вход любое число и выдает сумму цифр числа
// например: 452 ->11, 81 ->10; 9012 ->12.
Console.Clear();
Console.WriteLine("введите число: ");
int a = Convert.ToInt32(Console.ReadLine()), result = 0;
while (a > 0) 
{
    int b = a % 10;
    result = result + b;
    a = a / 10;
}
Console.WriteLine(result);
