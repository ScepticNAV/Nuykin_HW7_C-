/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetDemension(string message)                                      // Метод получения размерности матрицы
{
    Console.WriteLine(message);
    int demension = int.Parse(Console.ReadLine());
    return demension;
}

double[,] InitMatrix(int firstDemension, int secondDemension)          // Метод получения матрицы случайных вещественных чисел
{
    double[,] matrix = new double[firstDemension, secondDemension];
    Random rnd = new Random();
    for (int i = 0; i < firstDemension; i++)
    {
        for (int j = 0; j < secondDemension; j++)
            matrix[i, j] = rnd.NextDouble() * 100 - 50;
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)                                     // Метод вывода матрицы на печать с округлением чисел до сотых
{
    Console.WriteLine("Заполненная матрица:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double matrixNumber = Math.Round(matrix[i, j], 2);
            Console.Write(matrixNumber + "    ");
        }
    Console.WriteLine();
    }
}

int firstDemension = GetDemension("Введите число строк матрицы:");
int secondDemension = GetDemension("Введите число столбцов матрицы::");

double[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);