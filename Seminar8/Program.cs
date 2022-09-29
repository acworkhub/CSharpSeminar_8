// Задача 1: Задайте двумерный массив. Напишите программу,
//  которая поменяет местами первую и последнюю строку массива.

int[] InputSizeArray(string text)
{
    System.Console.WriteLine(text);
    int[] sizearray = new int[2];

    System.Console.WriteLine("Введите количество строк");
    sizearray[0] = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов");
    sizearray[1] = Convert.ToInt32(Console.ReadLine());
    return sizearray;
}

int[,] GenerateArray(int[] inputSize)
{
    int[,] newArray = new int[inputSize[0], inputSize[1]];
    var randon = new Random();
    for (int i = 0; i < inputSize[0]; i++)
    {
        for (int j = 0; j < inputSize[1]; j++)
        {
            newArray[i, j] = randon.Next(-10, 10);
        }
    }

    return newArray;
}
int[,] ChangeMirrorArray(int[,] inpMirrorArr)
{
    int row = inpMirrorArr.GetLength(0);
    int column = inpMirrorArr.GetLength(1);
    int[,] outMirrorArr = new int[row, column];
    if (row == 1)
    {
        for (int j = 0; j < column; j++)
        {
            outMirrorArr[row - 1, j] = inpMirrorArr[row - 1, j];
        }
    }
    else
    {
        for (int i = 0; i < row - 1; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (i == 0)
                {
                    outMirrorArr[i, j] = inpMirrorArr[row - 1, j];
                    outMirrorArr[row - 1, j] = inpMirrorArr[i, j];
                }
                else
                {
                    outMirrorArr[i, j] = inpMirrorArr[i, j];
                }
            }
        }
    }
    return outMirrorArr;
}

// // 2
// (bool, int[,]) RotateArray(int[,] inputRotateArr)

// {   bool flag = false;
//     int row = inputRotateArr.GetLength(0);
//     int column = inputRotateArr.GetLength(1);

//     int[,] outRotateArr = new int[row, column];
//     if (row == column)
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < column; j++)
//             {
//                 outRotateArr[j, i] = inputRotateArr[i, j];
//             }
//         }
//         flag = true;
//     }

//     return (flag, outRotateArr);
// }


// int[,] CountingValue(int[,] inputCountingArray)
// {
//     int row  = inputCountingArray.GetLength(0);
//     int column = inputCountingArray.GetLength(1);
//     int[,] CountingArr = new int[2, row * column];
//     int count = CountingArr.GetLength(0);
//     int c = 0;


//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//          CountingArr[0,c] = inputCountingArray[i, j];
//          c++;
//         }  
//     }

//     return CountingArr;
// }



//  Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и
//  столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

// int[,] FindCrossLineArray(int[,] inputCrossArray)
// {
//     System.Console.WriteLine("Введите число для определения координат");
//     int crossNumb = Convert.ToInt32(Console.ReadLine());

//     int row = inputCrossArray.GetLength(0);
//     int column = inputCrossArray.GetLength(1);
//     int[,] outCrossLineCoord = new int[1, 2];
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//         {
//             if (inputCrossArray[i, j] == crossNumb)
//             {
//                 outCrossLineCoord[0, 0] = i;
//                 outCrossLineCoord[0, 1] = j;
//                return outCrossLineCoord;   
//             }   
//         }
//     }
//                 outCrossLineCoord[0, 0] = - 1;
//                 outCrossLineCoord[0, 1] = - 1;

//         return outCrossLineCoord;
// }

// int[,] CrossLineFilter(int[,] inputArrays, int[,] crossPoint)
// {
//     int row  = inputArrays.GetLength(0) - 1;
//     int column = inputArrays.GetLength(1) - 1;
//     int crossrow = crossPoint[0,0];
//     int crosscolumn = crossPoint[0,1];
//     int[,] outCrossFilter = new int [row  , column ];
//     for (int i = 0; i < row  ; i++)
//     { 
       
//      for (int j = 0; j < column; j++)
//      {
//         if (crossrow == 0)
//         {
//             if ( crosscolumn == 0)
//             {
//             outCrossFilter[i, j] = inputArrays[i + 1, j + 1 ];
//             }
//             else outCrossFilter[i, j] = inputArrays[i + 1, j];
//         }
//          if (crossrow == row)
//         {
//             if ( crosscolumn == 0)
//             {
//             outCrossFilter[i, j] = inputArrays[i, j + 1 ];
//             }
//             else outCrossFilter[i, j] = inputArrays[i, j]; 
//         }

//         if (crossrow != 0 && crossrow != row)
//         {
//             if ( crosscolumn == 0)
//             {
//             outCrossFilter[i, j] = inputArrays[i + 1 , j + 1 ];
//             }
//              else outCrossFilter[i, j] = inputArrays[i + 1, j];
//         }
        
        
//      }
//     }
//     return outCrossFilter;
// }








void PrintArray(int[,] printarray)
{
    int row = printarray.GetLength(0);
    int column = printarray.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            System.Console.Write($"{printarray[i, j]}\t");
        }
        System.Console.WriteLine();
    }

}

// void PrintRotateArray(bool inputflag, int[,] printarray)
// {
//     int row = printarray.GetLength(0);
//     int column = printarray.GetLength(1);
//     if (inputflag == false)
//     {
//         System.Console.WriteLine("Невозможно транспонировать массив");
//     }
//     else
//     {
//         for (int i = 0; i < row; i++)
//         {
//             for (int j = 0; j < column; j++)
//             {
//                 System.Console.Write($"{printarray[i, j]}\t");
//             }
//             System.Console.WriteLine();
//         }
//     }
// }




int[] sizearray = InputSizeArray("Параметры массива");
var matrix = GenerateArray(sizearray);
PrintArray(matrix);
System.Console.WriteLine();

// var crossingLine = FindCrossLineArray(matrix);

// PrintArray(CrossLineFilter(matrix, crossingLine));

var mirrorarr = ChangeMirrorArray(matrix);
PrintArray(mirrorarr);

// (bool flagresult, int[,] rotatearray ) = RotateArray(matrix);
// PrintRotateArray(flagresult, rotatearray);
// var sum = CountingValue(matrix);
// PrintArray(sum);
