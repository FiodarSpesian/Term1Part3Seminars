void FillArrayTable(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue++;
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArrayTable(int[,] numbers, string massege = "Output array:")
{
    Console.WriteLine(massege);
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{numbers[i,j]}\t");
        }
        Console.WriteLine();
    }
}
void PrintArrayString(int[] array)
{
    Console.WriteLine("Output array:");
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{array[i]}\t");
    }
    Console.WriteLine();
}

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/
void Case54()
{
    int rows = 4;
    int colums = 4;
    int[,] table = new int[rows, colums];
    FillArrayTable(table);
    PrintArrayTable(table);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums - 1; j++)
        { 
            for (int k = 0; k < colums - 1 - j; k++)
            {
               if(table[i,k] < table[i,k + 1])
                {
                    int temp = table[i,k];
                    table[i,k] = table[i,k + 1];
                    table[i,k + 1] = temp;
                } 
            }
            
        }
    }
    PrintArrayTable(table, "Output sort table:");
}
//Case54();


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
void Case56()
{
    int rows = 5;
    int colums = 6;
    int[,] table = new int[rows, colums];
    FillArrayTable(table);
    PrintArrayTable(table);
    int[] arrayString = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < colums; j++)
        {
            sum = sum + table[i,j];
        }
        arrayString[i] = sum;
        Console.WriteLine($"Sum of {i} string: {sum}");
    }
    PrintArrayString(arrayString);
    int minIndex = 0;
    int minSumStringArray = arrayString[minIndex];
    for(int k = 0; k < rows; k++)
    {
        if(minSumStringArray > arrayString[k])
        {
            minSumStringArray = arrayString[k];
            minIndex = k;
        }
    }
    Console.WriteLine($"Index of string with the least sum: {minIndex}");
}
//Case56();


/*Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.*/
// Смог решить только до закомиченного кода, а дальше начались проблемы и не смог решить, пробовал по разному
void Case58()
{
    int rows = 4;
    int colums = 4;
    int[,] table = new int[rows, colums];
    int indexRow = 0;
    int indexColum = 0;

    int baisRow = 0;
    int baisColum = 1;

    int steps = colums;
    int turn = 0;
    for (int i = 0; i < table.Length; i++)
    {
        table[indexRow, indexColum] = i + 1;
        steps --;
        if(steps == 0)
        {
            steps = colums - 1 - turn/2;
            int temp = baisRow;
            baisRow = baisColum;
            baisColum = -temp;
            turn ++;
        }
        indexRow += baisRow;
        indexColum += baisColum;
    }
    PrintArrayTable(table);
}
//Case58();

/*Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
void Case61()
{
    int rowsFirst = 4;
    int columsFirst = 5;

    int rowsSecond = columsFirst;
    int columsSecond = 4;

    int[,] table1 = new int[rowsFirst, columsFirst];
    int[,] table2 = new int[rowsSecond, columsSecond];
    int[,] result = new int[rowsFirst, columsSecond];

    FillArrayTable(table1);
    FillArrayTable(table2);

    for (int i = 0; i < rowsFirst; i++)
    {
        for (int j = 0; j < columsSecond; j++)
        {
            for (int k = 0; k < columsFirst; k++)
            {
                result[i,j] += table1[i,k] * table1[k,j];
            }
        }
    }
    PrintArrayTable(result);
}
//Case61();
