using static System.Console;
Clear();

WriteLine("Введите количество строк в массиве: ");
int firstDimension = int.Parse(ReadLine()!);

WriteLine("Введите количество столбцов в массиве:");
int secondDimension = int.Parse(ReadLine()!);
WriteLine();

int[,] matrix = new int[firstDimension, secondDimension];

WriteLine("Сгенеринованный массив:");

FillArray(matrix);
PrintArray(matrix);
WriteLine();

WriteLine("Результат:");
int[,] squareArray = SquareElementsEvenIndex(matrix);
PrintArray(squareArray);
WriteLine();

void PrintArray(int[,] arr)
{
    int count_x = arr.GetLength(0);
    int count_y = arr.GetLength(1);
    
    for (int i = 0; i < count_x; i++)
    {
        for (int j = 0; j < count_y; j++)
            Write(arr[i, j] + "    ");
        WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] SquareElementsEvenIndex(int[,] arr)
{
    int count_x = arr.GetLength(0);
    int count_y = arr.GetLength(1);

    int[,] quadArr = new int[count_x, count_y];
    
    for (int i = 0; i < count_x; i++)
    {
        for (int j = 0; j < count_y; j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                quadArr[i,j] = arr[i,j] * arr[i,j];
            }
            else
            {
                quadArr[i,j] = arr[i,j];
            }
        }
    }
    return quadArr;
}


