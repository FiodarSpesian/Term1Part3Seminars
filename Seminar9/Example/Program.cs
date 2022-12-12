/*Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
void Case63()
{
    Console.WriteLine("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int counter = 1;
    Recursion63(number, counter);
}

void Test()
{
    Console.WriteLine("Hello!");
    Test();
}


void Recursion63(int number, int counter)
{
    if(counter > number) return;
    Console.Write($"{counter} ");
    counter++;
    Recursion63(number, counter);
}

/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" 
M = 4; N = 8 -> "4, 6, 7, 8"
*/
void Recursion65(int M, int N)
{
    if(M > N) return;
    Console.Write($"{M} ");
    M++;
    Recursion65(M, N);
}
void Case65()
{
    Console.WriteLine("Enter number M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    Recursion65(numM, numN);
}

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/
void Case67() // 1:00:00
{
    Console.WriteLine("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    SumDigits(number);
    Console.WriteLine(SumDigits(number));
}


int SumDigits(int number, int sum = 0)
{
    if(number == 0) return sum;
    sum += number %10;
    number /= 10;
    return SumDigits(number, sum);

}

/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3^5) 
A = 2; B = 3 -> 8*/

void Case69()
{
    Console.WriteLine("Enter number A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter number B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    PowAinB(A, B);

}
//Case69();
void PowAinB(int A, int B, int res = 1)
{
    if(B == 0) 
    {
        Console.WriteLine($"Answer: {res}");
        return;
    }
    res *= A;
    B--;
    PowAinB(A, B, res);
}