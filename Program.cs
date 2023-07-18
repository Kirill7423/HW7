// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double [,] Create2DArray ()
{
    Console.WriteLine("Введите число строк");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов");
    int userColls = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double [,] created2dArray = new double [userRows, userColls];

    for (int i = 0; i < userRows; i++)
    {
        for (int j =0; j < userColls; j++)
        {
            created2dArray[i,j] = Math.Round((new Random().Next(userMin, userMax + 1) + new Random().NextDouble()), 1);
        }
    }
    return created2dArray;
}

void Print2DArray(double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); 
}

double [,] newmassiv = Create2DArray();
Print2DArray(newmassiv);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int [,] Create2DArray () 
{
    int numRows = new Random().Next(0, 10);
    int numColls = new Random().Next(0, 10);
    int [,] created2dArray = new int [numRows, numColls];

    for (int i = 0; i < numRows; i++)
    {
        for (int j =0; j < numColls; j++)
        {
            created2dArray[i,j] = new Random().Next(0, 10);
        }
    }
    return created2dArray;
}

void Print2DArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void findElem(int [,] array)
{
    Console.WriteLine("Введите номер строки для вывода");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца для вывода");
    int b = Convert.ToInt32(Console.ReadLine());
    if ((a <= array.GetLength(0)) && (b <= array.GetLength(1)))
        Console.Write($"Значение элемента массива = {array[a,b]}");
    else
        Console.Write("Такого элемента в массиве нет"); 
} 
int [,] new2dArray = Create2DArray();
Print2DArray(new2dArray);
findElem(new2dArray);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Create2DArray () 
{
    int numRows = new Random().Next(0, 10);
    int numColls = new Random().Next(0, 10);
    int [,] created2dArray = new int [numRows, numColls];

    for (int i = 0; i < numRows; i++)
    {
        for (int j =0; j < numColls; j++)
        {
            created2dArray[i,j] = new Random().Next(1, 10);
        }
    }
    return created2dArray;
}

void Print2DArray(int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

int [,] newmassiv = Create2DArray();
Print2DArray(newmassiv);

void averageColl(int [,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        {
            double sumofElem = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sumofElem += array[i,j];
            }
        average = Math.Round((sumofElem / (array.GetLength(0))), 1);
        Console.Write($"{average}; ");
        }
    Console.WriteLine("\b\b.");
}

Console.Write("Среднее арифметическое столбцов: ");
averageColl(newmassiv);
