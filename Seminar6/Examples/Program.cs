void Case39()
{
    Random rand = new Random();
    int size = rand.Next(4, 7);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int[] result = new int[size];
    int maxIndex = size - 1;
    for (int i = 0; i < size; i++)
    {
        result[maxIndex - i] = numbers[i];
    }
    PrintArray(result);

    // 2 type desicion
    for (int i = 0; i < size/2; i++)
    {
        int temp = numbers[i];
        numbers[i] = numbers[maxIndex - i];
        numbers[maxIndex - i] = temp;
    }
    PrintArray(numbers);

    for (int i = 0; i < size/2; i++)
    {
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]);
    }
    PrintArray(numbers);
}
// Case39();

void FillArray(int[] numbers, int minValue = 0 , int maxValue = 9)
{
    Random rand = new Random();
    int length = numbers.Length;
    
    for (int i = 0; i < length; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] numbers)
{
    int length = numbers.Length;
    Console.WriteLine("Output array: ");

    for (int i = 0; i < length; i++)
        {
            Console.Write(numbers[i] + " ");
        }  
        
        Console.WriteLine("\n"); //   \n - переход на новую строку

}

//40 : Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

void Case40()
{
    int size = 3;
    int[] treug = new int[size];
    FillArray(treug, 1, 1000);
    PrintArray(treug);
    if(treug[1] < treug[0] + treug[2] &&
       treug[0] < treug[1] + treug[2] &&
       treug[2] < treug[1] + treug[0] ) Console.WriteLine("Available");
    else Console.WriteLine("Don't Available");
}

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 3 ->11
// 2 ->10
void Case42()
{
    Console.Write("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    int bais = 1;
    while (number > 0 )
    {
        result = result + (number%2) * bais ;
        number /= 2;
    }
    Console.WriteLine(result);
}

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void Case44()
{
    int N = Convert.ToInt32(Console.ReadLine());
    double num1 = 0;
    double num2 = 1;
    for (int count = 0; count < N; count++)
    {
        Console.Write(num1 + " ");
        double temp = num2;
        num2 = num1 + num2;
        num1 = temp;
    }
    Console.WriteLine();
}
// Задача 45:Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного
// копирования
void Case45()
{
    Random rand = new Random();
    int size = rand.Next(4, 7);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = numbers[i];
    }
    PrintArray(result);
}
Case45();
void CoppyArray(int[] firstArray, int[] secondArray)
{
    int size = firstArray.Length;
    for (int i = 0; i < size; i++)
    {
        secondArray[i] = firstArray[i];
    }
}