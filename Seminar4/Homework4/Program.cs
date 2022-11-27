/* Задача 25:
Используя определение степени числа, напишите цикл, 
который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
void Case25()
{
    Console.Write("Enter number A: ");
    double numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter degree B: ");
    double degreeB = Convert.ToInt32(Console.ReadLine());
    double result = Math.Pow(numberA, degreeB);
    Console.WriteLine($"{numberA} ^ {degreeB} = {result}");
}
//Case25();

void Case25_1()
{
    Console.Write("Enter number A and degree B through the space: ");
    string numbers = Console.ReadLine();
    string[] splnumber = numbers.Split(" ");
    double result = Math.Pow(Convert.ToInt32(splnumber[0]), Convert.ToInt32(splnumber[1]));
    Console.WriteLine($"number A = {splnumber[0]} in  degree B = {splnumber[1]} shape {result}");
}
//Case25_1();



/*Задача 27:
 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
void Case27()
{
    Random rand = new Random();
    int number = rand.Next(10, 10000);
    Console.WriteLine($"Generate random number: {number}");
    string stnumber = Convert.ToString(number);

    int size = stnumber.Length;
    double sum = 0;
    for (int i = 1; i <= size; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
Console.WriteLine($"Sum of all digits number is: {sum}");
}
//Case27();


/* Задача 29:     Сообшение для Дениса Сапрыкина:
                    "СПИСАЛ ИЗ РАЗБОРА Д/З 2 ДНЯ ПЫТАЛСЯ ЕЕ РЕШИТЬ И НИКАК НЕ ПОЛУЧАЛОСЬ, ПОСЛЕ ТАКОГО СЕМИНАРА ТЯЖКОВАТО БЫДО ДУМАТЬ
                    КОГДА ПОЯВИТСЯ ЗАПИСЬ СЕМИНАРА НА СВЕЖУЮ ГОЛОВУ БУДУ ДОБИВАТЬ РАЗБОР ЭТОЙ ЗАДАЧИ, ЧТОБЫ ПОЛНОСТЮ ПОНЯТЬ.
                    СПАСИБО ВАМ БОЛЬШОЕ!" (Watcher на семинарах)
 Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19] 
6, 1, -33 -> [1, 6, -33]
*/
void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue ++;
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
        Console.Write( nums[i] + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void Case29()
{
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers, -40, 40);
    PrintArray(numbers);

    for(int i = 0; i < size - 1; i++)
    {
        for (int j = 0; j < size - 1 - i; j++)
        {
            if(Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                int temp = numbers[j];
                numbers[j] = numbers[j+1];
                numbers[j+1] = temp;
            }
        }
          
    }
    PrintArray(numbers);
}
Case29();
