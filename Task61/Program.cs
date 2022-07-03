int [,] CreateArr (int n)
{
    return new int [n + 1,n];
}

void PrintArr(int [,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i++)
    {
            for (int j = 0; j < arr.GetLength(1); j++){   
            if(arr[i,j] != 0){
                Console.Write($"{arr[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}

void PascalTriangle(int[,] arr){
    
    for (int i = 1; i < arr.GetLength(0); i++){
        for (int j = 1; j < arr.GetLength(1); j++){
            arr[i,0] = 1;
            arr[i,j] = arr[i - 1,j -1] + arr[i - 1,j];

        }
    }
}

Console.WriteLine("Введите количество строк: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] arr = CreateArr(size);
PascalTriangle(arr);
PrintArr(arr);