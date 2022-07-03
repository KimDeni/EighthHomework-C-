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


void MinRow (int [,] arr){

    int tempMin = 0;
    int minR = 0;
    int minIndex = 0;
    
    for (int i = 0; i < 1; i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            minR = minR + arr[i,j];
        }
    }


    for (int i = 1; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            tempMin = tempMin + arr[i,j];
        }

        if(tempMin < minR){
            minR = tempMin;
            minIndex = i;
        }
        
    }


    Console.WriteLine($"{"Минимальная строка:"} {minIndex + 1}");
    Console.WriteLine($"{"Сумма ее элементов:"} {minR}");
}



Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
MinRow(arr);

