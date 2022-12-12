/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
void Case64()
{
    Console.Write("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Your number {number}, all digits till 1: ");
    ReverseOutNums(number);
}
void ReverseOutNums(int number)
{
    if(number == 0) return;
    Console.Write(number + " ");
    number --;
    ReverseOutNums(number);
}
//Case64();


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
void Case66()
{
    Console.Write("Enter start number M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter last number N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    Console.WriteLine(SumDigits(numberM, numberN, sum));
}
int SumDigits(int number1, int number2, int sum = 0)
{
    if(number1 > number2) return(sum);
    sum = sum + number1;
    number1 ++;
    return SumDigits(number1, number2, sum);
}
//Case66();



/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
void Case68()
{
    Console.Write("Enter first number M: ");
    int numFirst = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter second number N: ");
    int numSecond = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    Console.WriteLine("Mean of Akerman function: ");
    Console.WriteLine(Akerman(numFirst, numSecond, sum));
}
int Akerman(int firstM, int secondN, int mean = 0)
{
   if (firstM == 0) 
   {
        mean = mean + secondN + 1;
        return(mean);
   }
   if(firstM > 0 && secondN == 0)
   {
        return Akerman(firstM - 1, 1);
   }
   if( firstM > 0 && secondN > 0)
   {
        return Akerman(firstM - 1, Akerman(firstM, secondN - 1));
   }
   return Akerman(firstM, secondN, mean);
}
//Case68();