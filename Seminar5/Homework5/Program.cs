// подготовка к решению задач:
void FillArrayInt(int[] nums, int minValue, int maxValue)
{
    maxValue ++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}
void FillArrayDoub(double[] nums, int minValue, int maxValue)
{
    maxValue ++;
    int length = nums.Length;
    Random rand = new Random();
    for(int i = 0; i < length; i++) 
    {
        nums[i] = rand.Next(minValue,maxValue);
        for (int j = 0; j < length; j++)
        {
            double temp = nums[j];
            nums[j] = rand.NextDouble();
            nums[j] = Math.Round(temp + nums[j], 2);
        }
    }
}
void PrintArrayInt(int[] nums)
{
    int length = nums.Length; 
    Console.WriteLine("Output array: ");
    for(int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}
void PrintArrayDoub(double[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Output array: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine("\n");
}
void CountEvnNum(int[] nums)
{
    int size = nums.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if(nums[i] % 2 == 0)
        {
            count ++;
        }
        
    }
    Console.WriteLine(count + " even number in array");
}


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
            Напишите программу, которая покажет количество чётных чисел в массиве.
            [345, 897, 568, 234] -> 2
*/
void Case34()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArrayInt(numbers, 100, 1000);
    PrintArrayInt(numbers);
    CountEvnNum(numbers);
    
}

// Case34();


/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
void Case36()
{
    int size = 6;
    int[] array = new int[size];
    FillArrayInt(array, -10, 10);
    PrintArrayInt(array);
    int sum = 0;
    for(int i = 0; i < size; i++)
    {
        if(Math.Abs(array[i]) % 2 == 1) sum = sum + array[i];
    }
    Console.WriteLine("Sum of odd values of array: " + sum);
}
// Case36();



/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3,21 7,04 22,93 -2,71 78,24] -> 80,95
*/
void Case38()
{
    int size = 6;
    double[] mass = new double[size];
    FillArrayDoub(mass, -10, 20);
    PrintArrayDoub(mass);
    double maxMean = mass[0];
    double minMean = mass[0];
    double result;
    for (int i = 0; i < size; i++)
    {
        if(maxMean < mass[i]) maxMean = mass[i];
        if(minMean > mass[i]) minMean = mass[i];

    }
    Console.WriteLine("maxMean = " + maxMean);
    Console.WriteLine("minMean = " + minMean);
    result = maxMean - minMean;
    Console.WriteLine($"{maxMean} - ({minMean}) = {result}");
}
//Case38();