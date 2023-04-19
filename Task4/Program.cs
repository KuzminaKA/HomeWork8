// Задача 60.Сформируйте трёхмерный массив из случайных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] CreateArray ()
{
    int [,,] Array = new int [2, 2, 2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           for (int k = 0; k < Array.GetLength(2); k++)
           {
            Array[i,j,k] = new Random().Next(0, 10);
           }
        }
    }
    return Array;
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                System.Console.Write(Array[i,j,k] + $"({i},{j},{k}) ");
            }

        }
        System.Console.WriteLine();
    }
}

int [,,] array = CreateArray();
PrintArray(array);