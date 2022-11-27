/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет 
23432 -> да 
12821 -> да
*/
void Case19()
{
    Console.WriteLine("Напиште 5-тизечное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int firstDig = number / 10000;
    int secondDig = (number % 10000) / 1000;
    int fouthDig = (number % 100) / 10;
    int fifthDig = number % 10;
    if(firstDig == fifthDig & secondDig == fouthDig)
    {
        Console.WriteLine($"{number} число является палиндромом!");
    }
    else 
    {
        Console.WriteLine($"{number} число НЕ является палиндромом!");
    }
}
//Case19();



/*
Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84 
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
void Case21()
{
    Console.Write("Введите координаты точки А через пробел: ");
    string pointA = Console.ReadLine(); // Считываем строку из термиеала обязательно через " "
    Console.Write("Введите координаты точки Б через пробел: ");
    string pointB = Console.ReadLine(); // Считываем строку из термиеала обязательно через " "
    
    string[] pntASplit = pointA.Split(" "); // даем понять программе что 1 сторока которую ввели это массив разделённый пробедами
    string[] pntBSplit = pointB.Split(" "); // даем понять программе что 2 сторока которую ввели это массив разделённый пробедами

// ищем dist по математической формуле: корень из ((x1-x2)^2 + (y1-y2)^2 + (z1-z2)^2)

    double dist = Math.Sqrt(Math.Pow(Convert.ToInt32(pntASplit[0]) - Convert.ToInt32(pntBSplit[0]),2)
                + Math.Pow(Convert.ToInt32(pntASplit[1]) - Convert.ToInt32(pntBSplit[1]), 2)
                + Math.Pow(Convert.ToInt32(pntASplit[2]) - Convert.ToInt32(pntBSplit[2]), 2));
                // корень исчится с помощью команды Math.Sqrt()
                // квадрат исчится с помощью команды Math.Pow(аргумент, степень)
    Console.WriteLine($"Расстояние между точками в 3D пространстве равно: {dist}");
}
// Case21();


/*
Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/
void Case23()
{
    Console.WriteLine("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= number; i++)
    {
        double znach = Math.Pow(i,3);
        Console.WriteLine($"{i} ^ 3 = {znach}");
    }
}
//Case23();