// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void EvenNums(int m, int n)
{
    if (m >= n)
    {
        return;
    }
    if (m % 2 != 0)
    {
        m+= 1;
    }
    System.Console.Write($"{m}; ");
    EvenNums(m + 2, n);
}
int M = Prompt("Введите первое натуральное число > ");
int N = Prompt("Введите второе натуральное число > ");
EvenNums(M, N + 1);