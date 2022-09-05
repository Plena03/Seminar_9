// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.WriteLine("Программа вычисляет функцию Аккермана с помощью рекурсии.");
Console.WriteLine();

Console.Write("Введите число m: "); 
int m =  int.Parse(Console.ReadLine()); 
Console.WriteLine();

Console.Write("Введите число n: "); 
int n =  int.Parse(Console.ReadLine());
Console.WriteLine();

int A = Ackermann(m, n);

Console.Write($"Функция Аккермана = {A}");

int Ackermann(int m, int n)
{
    if (m == 0)
        {
        return n + 1;
        }
    else if (n == 0)
        {
        return Ackermann(m - 1, 1); 
        }
    else 
    {
        return Ackermann(m - 1, Ackermann(m, n - 1)); 
    }   
}

