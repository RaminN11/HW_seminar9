// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// void Main(string[] args)
//     {    
//             int n = 5;
//             PrintNatural(n);
//     }   

//          void PrintNatural(int n)
//     {    
//             if (n==0)
//             {
//                 return;
//             }
//             PrintNatural(n-1);
//             Console.WriteLine(n);
//     } 
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
PrintNatural(N);


void PrintNatural(int N)
{
    if (N<=0)   return;
    Console.WriteLine(N);
    PrintNatural(N-1);
}
  
