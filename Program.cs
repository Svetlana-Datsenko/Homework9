// // Задача 64: Задайте значения M и N. Напишите программу,
// // которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5. -> "1, 2, 3, 4, 5"
// // M = 4; N = 8. -> "4, 6, 7, 8"

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (M >= N) return;
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return (start + "\t" + PrintNumbers(start + 1, end));
// }

// Console.WriteLine(PrintNumbers(M, N));

// // Задача 66: Задайте значения M и N. Напишите программу, 
// // которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumber( int m, int n)
// {
//     if (n < m) return 0;
//     else return (n + SumNumber(m, n - 1));
// }
// Console.WriteLine($"Сумма чисел от {M} до {N} = {SumNumber(M,N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman (m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m,n-1));
}
Console.WriteLine($"m = {M}, n = {N} -> A(m,n) = {Akkerman(M,N)}");
