
void PrintArray(int[] array)
{
    Console.WriteLine("Output array: ");
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("\n");
}

/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
void Case41()
{
    Console.WriteLine("Enter numbers through the space: ");
    string numbers = Console.ReadLine();
    string[] temp = numbers.Split(" ");
    int size = temp.Length;
    int[] nums = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        
        nums[i] = Convert.ToInt32(temp[i]);
        if(nums[i] > 0) count ++;
    }
    PrintArray(nums);
    Console.WriteLine($"Count of pross numbers in array: {count}");

    
}
//Case41();




/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
             y = k1 * x + b1, 
             y = k2 * x + b2; 
             значения b1, k1, b2 и k2 задаются пользователем.
             b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
             x = (b2 - b1)/(k1 - k2)
             */
void Case43()
{
    Console.Write("Enter means K1 and B1 througt the spase: ");
    string line1 = Console.ReadLine();
    string[] array1 = line1.Split(" ");

    Console.Write("Enter means K2 and B2 througt the spase: ");
    string line2 = Console.ReadLine();
    string[] array2 = line2.Split(" ");
    double x;
    double y;
    x = ((Convert.ToDouble(array2[1]) - Convert.ToDouble(array1[1])) 
        / (Convert.ToDouble(array1[0]) - Convert.ToDouble(array2[0])));
    y = (Convert.ToDouble(array1[0])) * x + Convert.ToDouble(array1[1]);

    Console.WriteLine($"K1= {array1[0]}, B1 = {array1[1]}");
    Console.WriteLine($"K2= {array2[0]}, B2 = {array2[1]}");
    Console.WriteLine($"y= {y}, x= {x}");
}
//Case43();
