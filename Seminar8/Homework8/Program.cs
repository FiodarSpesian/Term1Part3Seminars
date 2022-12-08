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
               if(table[i,k] > table[i,k + 1])
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
    int colums = rows;
    int[,] table = new int[rows, colums];
    int count = 1;
    int temp;
    for (int i = 1; i < rows + 1; i++)
    {
        for (int j = 1; j < colums + 1; j++)
        {
            
            if(i - 1 == 0)
            {
                table[i - 1, j - 1] = count++;
            }
            else if(j == colums-1)
            {
                table[i - 1, j] = count++;
            }
            // else if(i == rows-1)
            // {
            //     table[i, colums - j] = count ++;
            // }
        }
    }
    PrintArrayTable(table);
}
Case58();

/*Задача 61: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/
void Case61()
{
    int rows = 4;
    int colums = 5;
    int[,] table1 = new int[rows, colums];
    int[,] table2 = new int[rows, colums];
    FillArrayTable(table1);
    PrintArrayTable(table1, "Output Table1:");
    FillArrayTable(table2);
    PrintArrayTable(table2, "Output Table2:");
    int[,] tableProdukt = new int[rows, colums];
    //PrintArrayTable(tableProdukt, "Output porodukt of Table1[]*Table2[]:");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            tableProdukt[i,j] = table1[i,j] * table2[i,j];
        }
    }
    PrintArrayTable(tableProdukt, "Output porodukt of Table1[,]*Table2[,]:");

}
//Case61();
