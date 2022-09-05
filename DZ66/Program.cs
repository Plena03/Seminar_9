// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Программа находит сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine();

Console.Write("Введите число m: "); 
int m =  int.Parse(Console.ReadLine()); 
Console.WriteLine();

Console.Write("Введите число n: "); 
int n =  int.Parse(Console.ReadLine());
Console.WriteLine();

int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

SumDigits(m, n, temp = 0);

void SumDigits(int m, int n, int sum)
{
    sum += n;
    if (n <= m)
    {
        Console.Write($"Сумма натуральных элементов = {sum}");
        Console.WriteLine();
        return;
    }
   
    SumDigits(m, n - 1, sum);
}

