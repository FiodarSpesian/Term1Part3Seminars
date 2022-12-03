/*Задача 46: 
Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4. 1 4 8 19 5 -2 33 -2
77 3 8 1*/
void Case46()
{
    int rows = 3;
    int colums = 4;

    int[,] numbers = new int[rows, colums];
    FillArrayRandom(numbers);
    PrintArray(numbers);
}
// . Case46();

void FillArrayRandom(int[,] numbers, int minValue = 0, int maxValue = 9)
{
    maxValue ++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
        numbers[i,j] = rand.Next(minValue, maxValue);
        }
    }
}
void PrintArray(int[,] numbers)
{
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


/*Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: A = m+n. Выведите полученный массив на экран.
m = 3, n = 4. 
0 12 3
1 23 4
2 34 5*/
void FillArraySumIndex(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int colums = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
        numbers[i,j] = i + j;
       
        }
    }
}
void Case48()
{
    int[,] nums = new int[3,4];
    FillArraySumIndex(nums);
    PrintArray(nums);
}
//Case48();

/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив выглядел вот так:
147 2 592 3 842 4
Новый массив будет выглядеть вот так:
147 2
5 81 2 9
842 4
*/

void Case49()
{
    int[,] table = new int[5,5];
    int rows = table.GetLength(0);
    int colums = table.GetLength(1);
    FillArrayRandom(table, 4, 9);
    Console.WriteLine("Output old table: ");
    PrintArray(table);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if(i % 2 ==0 && j % 2 ==0) table[i, j] = table[i, j] * table[i, j];
        }
    }
    Console.WriteLine("Output new table: ");
    PrintArray(table);
} 
//Case49();
/*Задача 51:
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0);
(1;1) и т.д.
Например, задан массив: 
1 4 72
5 9 23
8 4 24
Сумма элементов главной диагонали: 1+9+2 = 12
*/
void Case51()
{
    int rows = 5;
    int colums = 5;
    int[,] table = new int[rows, colums];
    FillArrayRandom(table, 0, 6);
    PrintArray(table);
    int min = Math.Min(rows, colums);
    int sum = 0;
    for (int i = 0; i < min; i++)
    {
        sum = sum + table[i, i];
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of main diagonal is {sum} ");
}
Case51();
