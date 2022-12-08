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
void PrintArray(int[,] numbers, string massege = "Output table:" )
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
    Console.WriteLine();
}
void PrintArrayString(int[] numbers, string messege = "Output array: ")
{
    Console.WriteLine(messege);
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{numbers[i]}\t");
    }
    Console.WriteLine();
}
/*Задача 53: Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку массива.*/
void Case53()
{
    int rows = 4;
    int colums = 5;
    int[,] table = new int[rows, colums];
    FillArrayRandom(table);
    PrintArray(table);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if(i == 0)
            {
                int temperaryValue;
                temperaryValue = table[i, j];
                table[i,j] = table[rows-1, j];
                table[rows-1, j] = temperaryValue;
            }
        }
    }
    Console.WriteLine("Output new table: ");
    PrintArray(table);
}

/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
           В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

void Case55()
{
    int rows = 4;
    int colums = 4;
    int[,] table = new int[rows, colums];
    FillArrayRandom(table);
    PrintArray(table);
    if(rows == colums)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < colums; j++)
            {
                int index = table[i,j];
            }
        }
        PrintArray(table);
    }
    else Console.WriteLine("Can't to be change colums and rows.");
    
}

/* Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.*/

void Case57()
{
    int rows = 5;
    int colums = 5;
    int[,] table = new int[rows, colums];
    FillArrayRandom(table, 0, 9);
    PrintArray(table);
    int[] dictinary = new int[10];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            dictinary[table[i, j]] ++;
        }
    }
    PrintDictionary(dictinary, "Output dictionary:");


    void PrintDictionary(int[] numbers, string messege = "Output array: ")
    {
         Console.WriteLine(messege);
        int size = numbers.Length;
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Value {i} can meet {numbers[i]} times");
        }
        Console.WriteLine();
    }
}
