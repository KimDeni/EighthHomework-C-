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

void ElemIndex(int [,] arr, int row, int col){

    int[] arrTemp = new int[row*col];
    int arrCounter = 0;
    int count = 1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrTemp[arrCounter] = arr[i,j];
            arrCounter++;
        }
    }

    Array.Sort(arrTemp);
    
    for (int i = 0; i < arrTemp.Length; i++)
    {
        Console.Write($"{arrTemp[i]} {" "}");
    }

    Console.WriteLine();

    for (int i = 0; i < arrTemp.Length - 1; i++)
    {
        if(arrTemp[i] == arrTemp[i + 1]){
            count++;
        }else{
            Console.WriteLine($"{arrTemp[i]} {"встречается"} {count} {"раз"}");
            count = 1;
        }
    }
    Console.WriteLine($"{arrTemp[arrTemp.Length - 1]} {"встречается"} {count} {"раз"}");
}


Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
ElemIndex(arr, row, col);
