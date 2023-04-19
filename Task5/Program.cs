// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

//Доделать не получилось!

int[,] CreateArray()
{
    int[,] Array = new int[4, 4];

    Array[0, 0] = 1;

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 1; j < Array.GetLength(1); j++)
        {
            Array[i, j] = Array[i, j - 1] + 1;
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           System.Console.Write(Array[i,j]+" ");
           
        }
        System.Console.WriteLine();
    }
}

int [,] array = CreateArray();
PrintArray(array);