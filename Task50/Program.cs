// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.Write("Введите номер строки:");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца:");
int columnsVol = Convert.ToInt32(Console.ReadLine());


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
void PrintElementMatrix(int[,] matrix)
{
  
            if (linesVol > matrix.GetLength(0) || columnsVol > matrix.GetLength(1)) {
                Console.Write($"{linesVol},{columnsVol} -> Такого элемента в массиве нет");
            }
            else Console.WriteLine($"Знаачение элемента = {matrix[linesVol-1,columnsVol-1]}");
        
    
}

int[,] array2D = CreateMatrixRndInt(3, 4, -99, 99);
PrintMatrix(array2D);
Console.WriteLine();
PrintElementMatrix(array2D);