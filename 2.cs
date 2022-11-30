using static System.Console;
Clear();

int[,] mat = GetMatrix(3, 4);

PrintMatrix(mat);


int[,] GetMatrix(int rows, int colums) 
{

    int[,] result = new int[rows, colums];


    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = i + j;
        }    
    }

    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
    WriteLine();
    }

}