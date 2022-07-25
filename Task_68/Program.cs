/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}

Console.Write("Введите число начала диапазона: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число конца диапазона: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(m, n);
Console.Write($"А({result})");