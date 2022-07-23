// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n. 
//m = 3, n = 2 -> A(m,n) = 29
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else 
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
}
int M = Prompt("Введите первое число больше нуля > ");
int N = Prompt("Введите второе число больше нуля > ");
System.Console.WriteLine(AkkermanFunction(M, N));
