// task25 программа принимает на вход 2 числа (A и B)и возводит A в 
// натуральную степень B. Не использовать Math.Pow 

Console.Clear();
Console.Write("Введите первое число");
int A = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число ");
int B = Convert.ToInt32(Console.ReadLine()), result = 1; 
for (int i = 1; i <= B; i++)
    result = result * A;
Console.WriteLine($"Результат: {result}");