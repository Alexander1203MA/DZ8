// // // Задание по автотесту номер 2
// int[,] CreateIncreasingMatrix(int n, int m, int k)  // Метод cоздает матрицу заданной размерности с каждым новым элементом увеличивающимся на опрделенное число K
// {
//     int[,] array = new int[n, m];
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = 1 + k * count;
//             count++;
//         }
//     return array;
// }


// void PrintArray(int[,] matrix) // Метод  выводить на экран сгенерированную методом выше матрицу 
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             System.Console.Write($"{matrix[i,j]}\t");
//         System.Console.WriteLine();
//     }
// }

// // int[] FindNumberByPosition(int[,] matrix, int rowPosition, int columnPosition) // Метод принимает на вход сгенрированную матрицу и проверяет заданные нам координаты и соответственно проверяет результат.
// {
//     int[] position = new int[] {0, 0};
//     if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
//         position[1] = 1 ;
//     else
//         position[0] = matrix[rowPosition- 1, columnPosition- 1];
//     return position;
// }

// // void PrintCheckIfError(int[] results, int x, int y) // Метод принимает результат метода выше и выдает нам итоговый ответ при полученных исходных данных.
// // {
//     if (results[1] == 1)
//         System.Console.WriteLine("There is no such index");
//     else
//         System.Console.WriteLine($"The number in [{x}, {y}] is {results[0]}");
// // }


// int n = 3;
// int m = 4;
// int k = 2;
// int x = 8;
// int y = 3;


// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);


// //Задание по автотесту 3
// void PrintArray(int[,] matrix) // Метод выводит на экран сгенерированную методом ниже матрицу
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             System.Console.Write($"{matrix[i, j]}\t");
//         System.Console.WriteLine();
//     }

// }

// int[,] CreateIncreasingMatrix(int n, int m, int k) // Метод создавет матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число K
// {
//     int[,] array = new int[n, m];
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = 1 + k * count;
//             count += 1;
//         }
//     return array;

// }

// void PrintListAvr(double[] list) // Метод принимает одномерный массив, возвращенный методом ниже 
// {
//     System.Console.WriteLine("The averages in columns are: ");
//     for (int i = 0; i < list.Length; i++)
//         System.Console.Write("{0:0.00}\t", list[i]);

// }

// double[] FindAverageInColumns(int[,] matrix) // Метод Fпринимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. Этот метод вычисляет среднее значение чисел в каждом столбце 
// {
//     double[] averageInColumns = new double[matrix.GetLength(1)];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double columnSum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//             columnSum += matrix[i, j];
//         averageInColumns[j] = columnSum / matrix.GetLength(0);
//     }
//     return averageInColumns;
// }
// // void Main(string[] args)
// // int n, m, k, x, y;
// // if (args.Length >= 5)
// // {
// //     n = int.Parse(args[0]);
// //     m = int.Parse(args[1]);
// //     k = int.Parse(args[2]);
// //     x = int.Parse(args[3]);
// //     y = int.Parse(args[4]);
// // }
// // else
// // {
// int n = 4;
// int m = 5;
// int k = 3;

// int[,] result = CreateIncreasingMatrix(n, m, k);
// PrintArray(result);
// PrintListAvr(FindAverageInColumns(result));