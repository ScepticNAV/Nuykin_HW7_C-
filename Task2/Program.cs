/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
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

void FindElement(int[,] matrix, int elementString, int elementRow)      // Метод поиска элемента с указанным индексом в матрице
{
    if  (((elementString > matrix.GetLength(0)) ||
        (elementString < 0)) ||
        ((elementRow > matrix.GetLength(1)) ||
        (elementRow < 0)))
        {
        Console.WriteLine("Элемента с указанным индексом в матрице нет");
        Console.WriteLine();
        }
    else
        {
        Console.WriteLine($"Элемент с указанным адресом = {matrix[elementString,elementRow]}");
        }
}

int firstDemension = GetDemension("Введите число строк матрицы:");
int secondDemension = GetDemension("Введите число столбцов матрицы:");
int[,] resultMatrix = InitMatrix(firstDemension, secondDemension);
PrintMatrix(matrix: resultMatrix);
int elementString = GetDemension("Введите индекс строки элемента, который хотите найти (отсчет с нуля):");
int elementRow = GetDemension("Введите индекс столбца элемента, который хотите найти (отсчет с нуля):");
FindElement(resultMatrix, elementString, elementRow);