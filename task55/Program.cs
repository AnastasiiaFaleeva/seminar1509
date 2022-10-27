// Задайте двумерный массив.
// Напишите программу которая заменяет строки на стоблцы.
// Или выдает что это невозможно сделать.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int[,] ReplaceRowsClumns(int[,] matrix)
{
    int[,] newArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           newArray[i,j] = matrix[j,i];
        }
    }
    return newArray;
}


int[,] myArray = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(myArray);
Console.WriteLine();

if (myArray.GetLength(0) == myArray.GetLength(1))
PrintMatrix (ReplaceRowsClumns(myArray));

else
Console.WriteLine("Невозможно заменить строки на столбцы ");