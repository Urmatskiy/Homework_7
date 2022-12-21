// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] CreateMassive(int rows, int columns, int first, int last)
{
    int[,] arr = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[i,j] = new Random().Next(first, last);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindNumberByIndex(int[,] arr, int index1, int index2)
{
    if (arr.GetLength(0) > index1 && arr.GetLength(1) > index2) Console.WriteLine(arr[index1, index2]);
    else Console.WriteLine("Такого элемента в массиве нет");
}

int rows = EnterData("Введите количество строк: ");
int columns = EnterData("Введите количество столбцов: ");
int firstIndex = EnterData("Введите значение первого индекса: ");
int secondIndex = EnterData("Введите значение второго индекса: ");
int[,] array = CreateMassive(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
FindNumberByIndex(array, firstIndex, secondIndex);
