int [,] CreateArr (int n, int m)
{
    return new int [n,m];
}

void FillArr(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,11);
        }
    }
}

void PrintArr(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
                for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}


void Sort (int [,] arr, int col){

    int[] temp = new int[col];

    for(int i = 0; i < arr.GetLength(0); i++){

        for(int j = 0; j < arr.GetLength(1); j++){
            temp[j] = arr[i,j];
        }

        Array.Sort(temp);
        Array.Reverse(temp);

        for(int j = 0; j < arr.GetLength(1); j++){
            arr[i,j] = temp[j];
        }

    }

}



Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
Sort(arr, col);
PrintArr(arr);