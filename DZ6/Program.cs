// int InputNum(string message)
// {
//     System.Console.WriteLine(message);
//     return int.Parse(Console.ReadLine()!);
// }

// void Amano(int num)
// {
//     for (int i = 1; i <=num; i++)
//     {
//         int res = (int)Math.Pow(i,3);
//         System.Console.WriteLine(res);
//     }
// }

// int number =InputNum("Введите число: ");
// Amano(number);

// int[] GetCoor (string message)
// {
//     int[] coordinates = new int[3];
//     System.Console.Write(message + "X: ");
//     coordinates[0] = int.Parse(Console.ReadLine()!);
//     System.Console.Write(message + "Y: ");
//     coordinates[1] = int.Parse(Console.ReadLine()!);
//     System.Console.Write(message + "Z: ");
//     coordinates[2] = int.Parse(Console.ReadLine()!);
//     return coordinates;
// }


// double Distance(int[]pointA, int[] pointB)
// {
//     int deltaX = pointB[0] - pointA[0] ;
//     int deltaY = pointB[1] - pointA[1] ;
//     int deltaZ = pointB[2] - pointA[2] ;
//     double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));
//     return dist;
// }

// int[] pointA = GetCoor("FFFDKJFPSJD ");
// int[] pointB = GetCoor("FFFDKJFPSJD ");
// double result = Distance(pointA , pointB);
// result = Math.Round(result, 2);
// System.Console.WriteLine(result);


// public class Answer
// {
//     static bool IsPalindrome(int number){
//         if (number < 10000 || number >= 100000){
//             Console.WriteLine("Число не пятизначное");
//             return false;
//         }

//         int reverse = 0;
//         int temp = number;
//         while (temp > 0){
//             reverse = reverse * 10 + temp % 10;
//             temp /= 10;
//         }
//         return reverse == number;
//     }

//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//             number = 645464;
//         }

//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }


// Console.WriteLine($"\nЗадача 25. Возведене числа A в натуральную степень B");

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     // int result = Math.Pow(numberA, numberB);
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponentiation = Exponentiation(numberA, numberB);
//   Console.WriteLine("Ответ: " + exponentiation);


// Console.WriteLine($"\nЗадание 27. Выдаёт сумму цифр в числе");
// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

//   int SumNumber(int numberN){
    
//     int counter = Convert.ToString(numberN).Length;
//     int advance = 0;
//     int result = 0;

//     for (int i = 0; i < counter; i++){
//       advance = numberN - numberN % 10;
//       result = result + (numberN - advance);
//       numberN = numberN / 10;
//     }
//    return result;
//   }

// int sumNumber = SumNumber(numberN);
// Console.WriteLine("Сумма цифр в числе: " + sumNumber);