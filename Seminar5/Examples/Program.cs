/*Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20. */

void Case31()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    FindsumPosElm(numbers);
    FindsumNegElm(numbers);
}

void FindsumNegElm(int[] nums)
{
    int sumNeg = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] < 0)
        {
        sumNeg += nums[i];
        }
    } 
    Console.WriteLine("Summ conth values: " + sumNeg);
}

void FindsumPosElm(int[] nums)
{
    int sumPos = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] > 0)
        {
        sumPos += nums[i];
        }
    } 
    Console.WriteLine("Summ proth values: " + sumPos);
}

void FillArray(int[] nums, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
       nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
{
    int length = nums.Length;
    Console.WriteLine("Output array: ");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + " " );
    }
    Console.WriteLine();
    Console.WriteLine();
}
//Case31();

/*Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/ // number[i] *= -1;
void Case32()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] < 0)
        {
            numbers[i] = Math.Abs(numbers[i]);
        }
        else
        {
            numbers[i] = numbers[i] * -1;
        }
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
//Case32();
/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 
3; массив [6, 7, 19, 345, 3] -> да */

void Case33()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    Console.WriteLine("Enter number which you are looking for: ");
    int digit = Convert.ToInt32(Console.ReadLine());
    bool flag = false;
    for (int i = 0; i < numbers.Length && !flag; i++)
    {
        flag = numbers[i] == digit;
        /*if(numbers[i] == digit)
        {
            flag = true;
        }*/
    }
    if(flag)
    {
            Console.WriteLine($"Array have number {digit}");

    }
    else
    {
         Console.WriteLine($"Array DONT have number {digit}");
    }
            
}
//Case33();

/*Задача 35: Задайте одномерный массив из 10 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

void Case35()
{
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 150);
    PrintArray(numbers);
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i]<100 && 10 < numbers[i])
        {
            count ++;
        }
    }
    Console.WriteLine($"Count of numbers in array: {count}");
}
//Case35();

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. 
[12345]->583
[6736]->3621 
*/
void Case37()
{
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 10);
    PrintArray(numbers);
    int halfSize = size / 2;
    int maxIndex = size - 1;
    int[] result = new int[halfSize + size%2];
    for (int i = 0; i < halfSize; i++)
    {
        result[i] = numbers[i] * numbers[maxIndex-i];
    }
    if(size%2 ==1 ) result[halfSize] = numbers[halfSize];
    PrintArray(result);
}
//Case37();