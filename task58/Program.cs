/* 
Задача 58: Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18                                                  
*/

int[,] generateArray(int height, int width, int firstElement, int lastElement)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i, j] = new Random().Next(firstElement, lastElement + 1);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void ShowArray(int[,] inputArray)
{
    Console.WriteLine();
    Console.Write(" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,]  MultiplicationOfTwoMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    int multiply;
    for (int i = 0; i < firstMatrix.GetLength(0); ++i)
    {
        for (int k = 0; k < secondMatrix.GetLength(1); k++)
        {
            multiply = 0;
            for (int j = 0; j < firstMatrix.GetLength(1); ++j)
            {
                multiply += firstMatrix[i, j] * secondMatrix[j, k];
            }
            result[i, k] = multiply;
        }
    }
    return result;
}

Console.WriteLine("Задайте массив для двух матриц.");
Console.Write("Количество строк: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int width = Convert.ToInt32(Console.ReadLine());

int[,] firstMatrix = generateArray(height, width, 1, 9);
ShowArray(firstMatrix);
int[,] secondMatrix = generateArray(height, width, 1, 9);
ShowArray(secondMatrix);

int[,] result =  MultiplicationOfTwoMatrices(firstMatrix, secondMatrix);
Console.WriteLine();
Console.WriteLine("Результирующая матрица будет:");
ShowArray(result);