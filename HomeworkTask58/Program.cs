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

int[,] MultMat(int [,] m1, int [,] m2, int [,] m3){
    
    for (int i = 0; i < m3.GetLength(0); i++){

        for (int j = 0; j < m2.GetLength(1); j++){

            for (int k = 0; k < m1.GetLength(1); k++){

                m3[i,j] += m1[i,k] * m2[k,j];
            }
        }
    }

    return m3;
}

Console.WriteLine("Введите количество строк первой матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Введите количество строк первой матрицы: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int col2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(col1 != row2){
    Console.WriteLine("Умножение данных матриц невозможно!");
} else{
    int[,] arr1 = CreateArr(row1, col1);
    FillArr(arr1);
    PrintArr(arr1);

    Console.WriteLine();

    int[,] arr2 = CreateArr(row2, col2);
    FillArr(arr2);
    PrintArr(arr2);

    Console.WriteLine();
    
    int[,] arr3 = CreateArr(col2, col2);
    PrintArr(MultMat(arr1, arr2, arr3));

}


