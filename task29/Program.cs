// task29 программа, которая задает массив из 8 элементов и предоставляет
// пользователю ввести числа и вывести их на экран
Console.Clear();
Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write("Введите элемент массива: ");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = new Random().Next(0, 99);
}
Console.WriteLine($"Результат:[{string.Join(" , ", array)}]");    

  

