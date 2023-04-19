// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int [,] CreateArray1 ()
{
    int [,] Array1 = new int [2, 2];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
           Array1[i,j] = new Random().Next(0, 10);
        }
    }
    return Array1;
}

int [,] CreateArray2 ()
{
    int [,] Array2 = new int [2,2];
    for (int i = 0; i < Array2.GetLength(0); i++)
    {
        for (int j = 0; j < Array2.GetLength(1); j++)
        {
           Array2[i,j] = new Random().Next(0, 10);
        }
    }
    return Array2;

}

int [,] JoinArray (int[,] Array1, int [,] Array2)
{
    int [,] joinArray = new int [2, 2];
    for (int i = 0; i < joinArray.GetLength(0); i++)
    {
        for (int j = 0; j < joinArray.GetLength(1); j++)
        {
            joinArray[i,j] = Array1[i,j]*Array2[i,j];
        }
    }
return joinArray;
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

int [,] array1=CreateArray1();
PrintArray(array1);
System.Console.WriteLine();
int [,] array2=CreateArray2();
PrintArray(array2);
System.Console.WriteLine("Произведение матриц:");
int [,] joinarray = JoinArray(array1,array2);
PrintArray(joinarray); 

