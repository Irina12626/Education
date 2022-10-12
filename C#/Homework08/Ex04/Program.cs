// Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

int n = 4;
int[,] totalMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= totalMatrix.GetLength(0) * totalMatrix.GetLength(1))
{
    totalMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < totalMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= totalMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > totalMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(totalMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
