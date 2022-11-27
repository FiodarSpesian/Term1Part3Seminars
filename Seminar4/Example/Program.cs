// Case 24
void Case24()
{
    Random rand = new Random();
    int number = rand.Next(1,16);
    Console.Write($"Added number: " + number);

    int counter = 1;
    int sum = 0;
    while (counter <= number)
    {
        Console.Write($"{sum} + {counter} = ");
        sum = sum + counter;
        Console.WriteLine(sum);
        counter ++;
    }
    Console.WriteLine("Answer: " + sum);

    sum = 0;
    while(number > 0)
    {
        sum += number;
        number --;
    }

}


//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
void Case26() 
{
    Random rand = new Random();
    int number = rand.Next();
    Console.WriteLine("Entered number: " + number);
    int count = 0;
    while(number > 0)
    {
        number = number / 10;
        Console.WriteLine(number);
        count ++;
    }
     Console.WriteLine("Count of digits: " + count);
}


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
void Case28()
{
    Random rand = new Random();
    int number = rand.Next(10, 15);
    Console.WriteLine("Entered number: " + number);
    int count = 1;
    int mult = 1;
    while(count < number)
    { 
        mult = mult * count;
        count ++;
    } 
    Console.WriteLine(mult);

}

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
// 0 1 2 3 4 5 6 7
// void FillArray(int[] nums)
// {

// }

// void PrintArray(int[] nums)
// {
//     int size = nums.Length;
//     for(int i = 0; )

// }

void Case30()
{
    int size = 8;
    Random rand = new Random();
    int[] numbers = new int[size];
    // Console.WriteLine(numbers[7]);
    for(int i = 0; i < size; i++)
    {
    numbers[i] = rand.Next(0,2);
    Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
//Case30();
