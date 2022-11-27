void Case17() 
{
    /*Напишите программу, которая принимает на вход координаты точки (X и Y), 
    причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/
    Random rand = new Random();
    //тип_данных имя_переменной = new тип_данных();
    int x = rand.Next(-10,11);
    int y = rand.Next(-10,11);
    Console.WriteLine($"A({x}, {y})");
    if(x > 0 && y > 0)
    {
        Console.WriteLine("1-я четверть");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("2-я четверть");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("3-я четверть");
    }
    else if(x > 0 && y < 0)
    {
        Console.WriteLine("4-я четверть");
    }
    else 
    {
        Console.WriteLine("Точка лежит на координатной прямой");
    }
}
// Case17();


void Case18()
{
//Задача 18: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y)
    Random rand = new Random();
    //тип_данных имя_переменной = new тип_данных();
    Console.WriteLine("Введите номер четверти:");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number == 1)
    {
        Console.WriteLine("1-я четверть: A(x,y) == [+ много,+ много]");
    }
    else if(number == 2)
    {
        Console.WriteLine("2-я четверть: A(x,y) == [- много,+ много]");
    }
    else if( number == 3)
    {
        Console.WriteLine("3-я четверть: A(x,y) == [- много,- много]");
    }
    else if(number == 4)
    {
        Console.WriteLine("4-я четверть: A(x,y) == [+много,-много]");
    }
    else 
    {
        Console.WriteLine("Такой четверти не существует");
    }
}
// Case18();



/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21*/

//int x = 5;
//Math.Pow(x, 2);
//Math.Sqrt(x);
//Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));


void Case21()
{
int x1, y1,
    x2, y2;
Console.WriteLine("Enter number1 A(x1,y1): ");
Console.Write("x1: ");
x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number1 A(x2,y2): ");
Console.Write("x2: ");
x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
y2 = Convert.ToInt32(Console.ReadLine());

double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
Console.WriteLine(Math.Round(dist, 3));
}
//Case21();
void Zadacha21()
{
    Console.WriteLine("Введите координаты точки А через пробел");
    string pointA = Console.ReadLine();
    Console.WriteLine("Введите координаты точки В через пробел");
    string pointB = Console.ReadLine();

    string[] pointASplit = pointA.Split();
    string[] pointBSplit = pointB.Split();

    double distance = Math.Sqrt(Math.Pow(Convert.ToInt32(pointASplit[0]) - Convert.ToInt32(pointBSplit[0]), 2)
                        + Math.Pow(Convert.ToInt32(pointASplit[1]) - Convert.ToInt32(pointBSplit[1]), 2));
    
    Console.WriteLine(distance);
}

// Zadacha21();

// Case 22 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
void Case22()
{
    Console.Write("Enter number: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    double sqer;
    while(N >= count)
    {
        sqer = Math.Pow(count, 2);
        Console.WriteLine($"Квадрат числа {count} равен {sqer}");
        count ++;
    }

}
//Case22();