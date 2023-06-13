// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void ChangeRows(int[,] Array)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        (Array[0,j],Array[Array.GetLength(0)-1,j]) = (Array[Array.GetLength(0)-1,j],Array[0,j]);
    }
}


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(-30,31);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i,j],3}    ");
        System.Console.WriteLine();
        }
}



Console.Clear();
System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
ChangeRows(array);
PrintArray(array);


// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i,j] = new Random().Next(-30,31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write($"{array[i,j],3}    "); 
//         System.Console.WriteLine();
//         }
// }

// void ChangeMatrix(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int temp = array[0,i]; // здесь можно было сделать множетвенное присваивание
//         array[0,i] = array[array.GetLength(0)-1, i];
//         array[array.GetLength(0)-1, i] = temp;
//     }     
// }

// Console.Clear();
// System.Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// System.Console.WriteLine();
// ChangeMatrix(array);
// PrintArray(array);