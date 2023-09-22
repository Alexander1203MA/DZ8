System.Console.WriteLine("Задача 64"); //Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToNum(number, count);

void NaturalToNum(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalToNum(n, count + 1);
        Console.Write(count + " ");
    }
}


// System.Console.WriteLine("Задача 66");//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// SumFromMToN(m, n);

// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }


// System.Console.WriteLine("Задача 68");// Напишите программу вычисления функции Аккермана с помощью рекурсии
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);


// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }
