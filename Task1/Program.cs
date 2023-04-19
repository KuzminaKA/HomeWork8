// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] CreateArray (int length1, int lenght2)
{
    int [,] Array = new int [length1, lenght2];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
           Array[i,j] = new Random().Next(0, 10);
        }
    }
    return Array;
}

void SortArray(int[,] Array)
{
        for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1)-1; j++)
        {
            int maxPosition= j;
            for (int k = j+1; k < Array.GetLength(1); k++)
            {
                if(Array [i,k]>Array[i,maxPosition])
                {maxPosition=k;}
            }
           int temp=Array[i,j];
           Array[i,j] = Array[i, maxPosition];
           Array[i,maxPosition]=temp;
            
        }
    }

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

int [,] array = CreateArray(4,4);
PrintArray(array);
SortArray(array);
System.Console.WriteLine();
PrintArray(array);