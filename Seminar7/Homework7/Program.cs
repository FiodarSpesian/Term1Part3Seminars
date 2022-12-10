void FillArrayRandomInt(int[,] table, int minValue = 0, int maxValue = 9)
{
    maxValue ++;
    Random rand = new Random();
    int rows = table.GetLength(0);
    int colums = table.GetLength(1);
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            table[i,j] = rand.Next(minValue, maxValue);
        }
    }
}
void FillArrayRandomDouble(double[,] table)
{
    Random rand = new Random();
    int rows = table.GetLength(0);
    int colums = table.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            table[i, j] = Math.Round(rand.NextDouble() * 10, 2);
        }
    }
}
void PrintArrayInt(int[,] table)
{
    Console.WriteLine("Output table: ");
    int rows = table.GetLength(0);
    int colums = table.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{table[i,j]}\t" );
        }
        Console.WriteLine();
    }
}
void PrintArrayDouble(double[,] table)
{
    Console.WriteLine("Output table: ");
    int rows = table.GetLength(0);
    int colums = table.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            Console.Write($"{table[i,j]}\t" );
        }
        Console.WriteLine();
    } 
}

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
void Case47()
{
    int rows = 4;
    int colums = 4;
    double[,] arr = new double[rows, colums];
    FillArrayRandomDouble(arr);
    PrintArrayDouble(arr);
}
Case47();


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
// Дополнительное условие к решению:
// Так как эта программа может использоваться обычными людми(не программистами) в 93 и 94 строку добавляем -1 
// т.к. у них отсчет начинаеся с 1 а не с 0 как у программистов 
void Case50()
{
    int rows = 4;
    int colums = 6;
    int[,] table = new int[rows, colums];
    FillArrayRandomInt(table);
    PrintArrayInt(table);
    Console.WriteLine("Enter location of the number by 2 means. Write it through the space: ");
    string numbers  = Console.ReadLine(); 
    string[] nums = numbers.Split(" ");
    int firstPos = Convert.ToInt32(nums[0]) - 1;
    int secondPos = Convert.ToInt32(nums[1]) - 1;
    if(rows > firstPos && colums > secondPos) 
    {
        rows = firstPos;
        colums = secondPos;
        Console.WriteLine($"Your number is: {table[rows, colums]}");
    }
    else Console.WriteLine($"Error: your number is out of array.");
}
//Case50();


/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void Case52()
{
    int rows = 7;
    int colums = 5;
    int[,] table = new int[rows, colums];
    FillArrayRandomInt(table);
    PrintArrayInt(table);
    double tempSum; //= Convert.ToDouble(sum);
    double result;
    double rowsDiv = Convert.ToDouble(rows);
    Console.WriteLine("Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < colums; j++)
    {
        int sum = 0;
        for (int i = 0; i < rows; i++)
        {
            sum = sum + table[i,j];
        }
        tempSum = Convert.ToDouble(sum);
        result = Math.Round(tempSum / rowsDiv, 2);
        Console.Write($"{result}\t");
    }
}
//Case52();


