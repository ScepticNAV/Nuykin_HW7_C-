/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetDemension(string message)                                        // Метод получения размерности матрицы
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

int[,] InitMatrix(int firstDemension, int secondDemension)               // Метод получения матрицы случайных целых чисел
{
    int[,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.Next(1, 20);
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)                                         // Метод вывода матрицы на печать
{
    Console.WriteLine("Заполненная матрица");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}    ");

        Console.WriteLine();
    }
}

void FindArithmeticMean(int[,] matrix)                   // Метод поиска среднего арифметического элементов в каждом столбце
{
    Console.WriteLine();
    Console.WriteLine(matrix.GetLength(0));
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum / matrix.GetLength(0)}  ");
    }
    Console.ReadLine();
}

int firstDemension = GetDemension("Введите число строк матрицы:");
int secondDemension = GetDemension("Введите число столбцов матрицы:");
int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);
FindArithmeticMean(resultMatrix);
