// Задача 2: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumNums(int m, int n)
{
    if (m > n)
    {
        return 0;
    }

    return SumNums(m + 1, n) + m;

}
int M= Prompt("Введите первое натуральное число > ");
int N = Prompt("Введите второе натуральное число > ");
System.Console.WriteLine(SumNums(M, N));
