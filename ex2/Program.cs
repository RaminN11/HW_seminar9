// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите значение M: ");
int M =int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N: ");
int N = int.Parse(Console.ReadLine()!);
PrintNatural(M,N);

void PrintNatural(int M,int N)
{
    int sum = 0;
     for (int i = M; i <= N; i++)
        {
            sum += i;
        }

    
        Console.WriteLine($"Сумма натуральных элементов от {M} до {N} равна {sum}");
}