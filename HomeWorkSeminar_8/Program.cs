


// int[] SizeArrayParametr(string text)
// {
//     System.Console.WriteLine(text);
//     int[] data = new int[2];

//     System.Console.WriteLine("Kolichestvo strok");
//     data[0] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Kolichestvo stolbtsov");
//     data[1] = Convert.ToInt32(Console.ReadLine());
//     return data;
// }


// int[,] GenerateArray(int[] inputData)
// {
//     int[,] newArray = new int[inputData[0], inputData[1]];
//     var random = new Random();
//     for (int i = 0; i < inputData[0]; i++)
//     {
//         for (int j = 0; j < inputData[1]; j++)
//         {
//             newArray[i, j] = random.Next(-5, 20);
//         }
//     }
//     return newArray;
// }

// void PrintArray(int[,] inputPrintData)
// {
//     int row = inputPrintData.GetLength(0);
//     int columns = inputPrintData.GetLength(1);

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             System.Console.Write($"{inputPrintData[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] OrderTransformarray(int[,] transformArr)
// {

//     int row = transformArr.GetLength(0);
//     int column = transformArr.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             for (int k = 0; k < column - 1; k++)
//             {
//                 int temp = 0;
//                 if (transformArr[i, k] < transformArr[i, k + 1])
//                 {
//                     temp = transformArr[i, k];
//                     transformArr[i, k] = transformArr[i, k + 1];
//                     transformArr[i, k + 1] = temp;
//                 }
//             }
//         }
//     }
//     return transformArr;
// }


// var arrayParam = SizeArrayParametr("Vvedite parametri");
// var arr = GenerateArray(arrayParam);
// PrintArray(arr);
// var sort = OrderTransformarray(arr);
// System.Console.WriteLine();
// PrintArray(sort);


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// (int, int) FindMinSumColumn(int[,] inputArray)
// {
//     int row = inputArray.GetLength(0);
//     int column = inputArray.GetLength(1);
//     int minvalue = 0;
//     int numbcolumn = 0;

//     for (int i = 0; i < row; i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < column; j++)
//         {   
//             sum += inputArray[i, j]; 
//         }
//          if (i == 0)
//             {
//                 numbcolumn = 1;
//                 minvalue = sum;
//             }
//             if (i > 0 && sum < minvalue)
//             {
//                 numbcolumn = i + 1;
//                 minvalue = sum;
//             }
//     }

//     return (numbcolumn, minvalue);
// }


// var arrayParam = SizeArrayParametr("Vvedite parametri");
// var arr = GenerateArray(arrayParam);
//  PrintArray(arr);
// (int numbcolumn, int minvalue) = FindMinSumColumn(arr);
// System.Console.WriteLine();
// System.Console.WriteLine($"Minimalnoe znachenie stroka => {numbcolumn}, znachenie => {minvalue}");





///////////////////////////////////////////////////////////////////////////////////////////////////

// int[,] A = new int[2, 2] { { 2, 4 }, { 3, 2 } };
// int[,] B = new int[2, 2] { { 3, 4 }, { 3, 3 } };
// PrintArray(A);
// PrintArray(B);

// int[,] MatrixMultiply(int[,] MatrixArr1, int[,] MatrixArr2)
// {
//     int row1 = MatrixArr1.GetLength(0);
//     int column1 = MatrixArr1.GetLength(1);
//     int row2 = MatrixArr2.GetLength(0);
//     int column2 = MatrixArr1.GetLength(1);
//     int[,] ResultMultiply = new int[row1, column1];

//     if (row1 != row2 && column1 != column2)
//     {
//         System.Console.WriteLine("Matritsi imeiut raznie razmeri");
//     }

//     else
//     {
//         for (int i = 0; i < row1; i++)
//         {
//             for (int j = 0; j < column1; j++)
//             {
//                 int sum = 0;

//                 for (int k = 0; k < column1; k++)
//                 {
//                     sum += MatrixArr1[i, k] * MatrixArr2[k, j];
//                 }
//                 ResultMultiply[i, j] = sum;
//             }
//         }
//     }
//     return ResultMultiply;
// }

// System.Console.WriteLine();

// PrintArray(MatrixMultiply(A, B));


// var arrayParam = SizeArrayParametr("Vvedite parametri");
// var arr = GenerateArray(arrayParam);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// int[] SizeArrayParametr3D(string text)
// {
//     System.Console.WriteLine(text);
//     int[] data = new int[3];
//     System.Console.WriteLine("Kolichestvo strok");
//     data[0] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Kolichestvo stolbtsov");
//     data[1] = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Kolichestvo izmereniy");
//     data[2] = Convert.ToInt32(Console.ReadLine());
//     return data;
// }

// int[,,] GenerateArray3D(int[] inputData)
// {
//     int[,,] newArray = new int[inputData[0], inputData[1], inputData[2]];
//     var random = new Random();


//     for (int g = 0; g < inputData[2]; g++)
//     {
//         for (int i = 0; i < inputData[0]; i++)
//         {
//             for (int j = 0; j < inputData[1]; j++)
//             {
//                 newArray[i, j, g] = random.Next(-10, 11);
//             }
//         }
//     }
//     return newArray;
// }

// void PrintArray3D(int[,,] inputPrintData)
// {
//     int row = inputPrintData.GetLength(0);
//     int columns = inputPrintData.GetLength(1);
//     int weight = inputPrintData.GetLength(2);
//     for (int g = 0; g < weight; g++)
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 System.Console.Write($"({g},{i},{j}) => {inputPrintData[i, j, g]}\t");
//             }
//             System.Console.WriteLine();
//         }
//         System.Console.WriteLine();
//     }
// }
// var size3d = SizeArrayParametr3D("Parametri 3d massiva");
// PrintArray3D(GenerateArray3D(size3d));

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// void SnakeFillCellRight(int[,] InputArr, int row, int column, int step)
// {
//     if (InputArr[row, column] == 0)
//     {
//         InputArr[row, column] = step;
//         step++;
//         if (column < InputArr.GetLength(1) - 1 && InputArr[row, column + 1] == 0) { SnakeFillCellRight(InputArr, row, column + 1, step); }
//         else { SnakeFillCellDown(InputArr, row + 1, column, step); }
//     }
// }

// void SnakeFillCellDown(int[,] InputArr, int row, int column, int step)
// {
//     if (InputArr[row, column] == 0)
//     {
//         InputArr[row, column] = step;
//         step++;

//         if (row < InputArr.GetLength(0) - 1 && InputArr[row + 1, column] == 0) { SnakeFillCellDown(InputArr, row + 1, column, step); }
//         else { SnakeFillCellLeft(InputArr, row, column - 1, step); }
//     }
// }

// void SnakeFillCellLeft(int[,] InputArr, int row, int column, int step)
// {
//     if (InputArr[row, column] == 0)
//     {
//         InputArr[row, column] = step;
//         step++;
//         if (column > 0 && InputArr[row, column - 1] == 0) { SnakeFillCellLeft(InputArr, row, column - 1, step); }
//         else { SnakeFillCellUp(InputArr, row - 1, column, step); }
//     }
// }

// void SnakeFillCellUp(int[,] InputArr, int row, int column, int step)
// {
//     if (InputArr[row, column] == 0)
//     {
//         InputArr[row, column] = step;
//         step++;
//         if (row > 0 && InputArr[row - 1, column] == 0) { SnakeFillCellUp(InputArr, row - 1, column, step); }
//         else { SnakeFillCellRight(InputArr, row, column + 1, step); }
//     }
// }

// var arraySnake = new int[10, 10];
// PrintArray(arraySnake);
// System.Console.WriteLine();
// SnakeFillCellRight(arraySnake, 0, 0, 1);
// PrintArray(arraySnake);
///////////////////////////////////////////////////////////////////////////////////////////////////////////////