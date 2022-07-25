/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void SumNumRec(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (M++);
    SumNumRec(M, N, sum);
}

Console.Write("Введите число начала диапазона: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число конца диапазона: ");
int N = Convert.ToInt32(Console.ReadLine());
SumNumRec(M, N, 0);