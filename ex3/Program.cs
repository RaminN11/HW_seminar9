// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9


int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    else 
     return 0;
    

}
int m = 2;
int n = 3;
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");


//Никак не получается при m=2 и n=3 получить 29, формулу вроде правильно составил
