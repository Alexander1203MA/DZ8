// Console.WriteLine("Задание 2");
// Console.Write("введите первое целое число :");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе целое число :");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int max = num1 ;
// if (num1 >= num2) 
//     Console.WriteLine($"Первое число больше чем второе :{max} > {num2}");
// else
//     Console.WriteLine($"Второе число больше чем первое :{num2} > {max}");
//     max = num2 ;



// Console.WriteLine("");
// Console.WriteLine("Задание 4");
// Console.Write("введите первое целое число :");
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите второе целое число :");
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите третье целое число :");
// int num5 = Convert.ToInt32(Console.ReadLine());
// int Mmax =num3 ;
// if (num4 > num3)
//     Mmax = num4;
// if (num5 > Mmax)
//     Mmax = num5;
// Console.Write($"Получаем максимальное число:{Mmax}");


// Console.WriteLine("");
// Console.WriteLine("Задание 6");
// Console.Write("введите первое целое число :");
// int num6 = Convert.ToInt32(Console.ReadLine());
// int chet =  num6 % 2 ;
// if (chet ==0)
//     Console.WriteLine("Число чётное") ;
// else 
//     Console.WriteLine ("Число нечётное") ;



// Console.WriteLine("");
// Console.WriteLine("Задание 8");
// Console.Write("Введите число :");
// int num7 = Convert.ToInt32(Console.ReadLine());
// int evenNumber = 2;

// if(num7 > 1)
// {
//     while(evenNumber <= num7)
//     {
//         Console.Write($"{evenNumber} ");
//         evenNumber = evenNumber + 2;
//     }
// }



// Console.WriteLine(" ");
// Console.WriteLine("Задание 7 Hard");  
// int threechislo(int number)
// {
//     int result = -1;
//         if (number >= 100)
//             {
//                 while (number > 999)
//                 {
//                     number = number / 10;
//                 }
//                 result = number % 10;
//             }
//             return result; 
// }
// Console.Write("Введите число : ");
// int number1 = Convert.ToInt32(Console.ReadLine()); 
// if (threechislo(number1) == -1)
//     Console.WriteLine("Третьей цифры в этом числе нет");
// else
//     Console.WriteLine($"Третье число слева от этого числа это : {threechislo(number1)}");


// Console.WriteLine(" ");
// Console.WriteLine("Задание 2 Hard");
// Console.Write("Введите число :");
// double num8 =Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"{num8}") ;
// int count = 0 ;
// while (num8 > 0)
// {
//     count ++ ;
//     num8 = num8 / 10 ;
// }
// Console.WriteLine($"{count}") ;
