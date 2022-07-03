int [,] CreateArr (int n)
{
    return new int [n,n];
}

void PrintArr(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
            for (int j = 0; j < arr.GetLength(1); j++){   
                Console.Write($"{arr[i,j]} {" "}");
        }
        Console.WriteLine();
    }
}

void SpiralFill(int[,] arr, int n){
    int num = 1;


    for( int ins = 0; ins < n - 2; ins++){

        for (int i = 0 + ins; i < n - ins; i++){
            arr[0 + ins, i] = num;
            num++;
        }
        num--;

        for (int i = 0 + ins; i < n - ins; i++){
            arr[i, n - 1 - ins] = num;
            num++;
        }
        num--;

            for (int i = n - 1 - ins; i >= 0 + ins; i--){
            arr[n - 1 - ins,i] = num;
            num++;
        }
        num--;

        for (int i = n - 1 - ins; i > 0 + ins; i--){
            arr[i,0 +  ins] = num;
            num++;
        }
        
    }

}

Console.WriteLine("Введите размер матрицы: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateArr(size);
SpiralFill(arr, size);
PrintArr(arr);