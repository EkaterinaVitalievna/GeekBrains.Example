// Двумерные массивы
//string[,] table = new string[2, 5];
//String.Empty - инициализация для строк, Empty - пустая строка
// table[0, 0] table [0, 1] table [0, 2] table [0, 3] table [0, 4]
// table [1, 0] table [1, 1] table [1, 2] table [1, 3] table [1, 4]

// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)//количество строк не больше 2
// {
//     for (int columns = 0; columns < 5; columns++)//вложенный цикл, количество столбцов не больше 5
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} "); // write, чтобы не переходить на след.строку
        }
    Console.WriteLine(); //принудительно переходим на след.строку
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(5,25);//ПОЛУИНТЕРВАЛ!
        }
    }
}

int[,] matrix = new int[3, 4]; //важно указать количество строк и столбцов, чтобы в массиве было выделено место
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);