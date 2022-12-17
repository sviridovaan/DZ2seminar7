//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет
Console.Clear();


void ShowArray(int [,] array)
{
    for (int i = 0; i<array.GetLength(0) ; i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int [,] array = new int[rows, columns]; 
    for (int i = 0; i<rows ; i++)
    {
        for (int j = 0; j<columns; j++)
        {
            array [i,j] = new Random().Next(leftRange, rightRange);
        }
    }
    return array;
}

int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int m = EnterNumber("Введите значение m: ");
int n = EnterNumber("Введите значение n: ");

int [,] matrix= CreateRandomArray(m, n, 1, 10);
ShowArray(matrix);

int DataNumb(string message)
{
    Console.WriteLine(message);
    int numb = int.Parse(Console.ReadLine());
    return numb;
}

int x = DataNumb("Введите число, обозначающее позицию элемента строки ");
int y = DataNumb("Введите число, обозначающее позицию элемента столбца ");

if (x-1 < matrix.GetLength(0) && y-1 < matrix.GetLength(1))
{
    Console.WriteLine($"Числo с позицией элемента строки {x} и столбца {y} равно {matrix[x-1, y-1]}");
}
else
{  
    Console.WriteLine($"Числа с позицией элемента строки {x} и столбца {y} в массиве нет");
}