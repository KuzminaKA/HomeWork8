// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Доделать не получилось!

int[,] CreateArray(int length1, int lenght2)
{
    int[,] Array = new int[length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(0, 10);
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
            System.Console.Write(Array[i, j] + " ");

        }
        System.Console.WriteLine();
    }
}

int StringMin(int[,] array)
{
    int minimumSum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Sum = Sum + array[i, j];
        }
        minimumSum=Sum;
    }
return minimumSum;
}


int[,] array = CreateArray(3, 4);
PrintArray(array);
int min = StringMin(array);
System.Console.WriteLine();
System.Console.WriteLine(min);