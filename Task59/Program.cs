int [,] CreateArr (int n, int m)
{
    return new int [n,m];
}

int [,] FillArr(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 11);
        }
    }

    return arr;
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

void DelArr(int[,] arr, int row, int col){

    int minI = 0; 
    int minJ = 0; 
    int min = arr[0,0];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i,j] < min){
                    min = arr[i,j];
                    minI = i;
                    minJ = j;
                }
            }
    }

    int[,] delRowArr = new int[row - 1, col];

    int countI = 0;

    for (int i = 0; i < delRowArr.GetLength(0); i++){
        if(minI == i){
            countI++;
        }
        for (int j = 0; j < delRowArr.GetLength(1); j++)
            {
                delRowArr[i,j] = arr[countI,j];                
            }
            countI++;
    }

    int[,] delColArr = new int[row - 1, col - 1];

    int countJ = 0;

    for (int i = 0; i < delColArr.GetLength(0); i++){

        for (int j = 0; j < delColArr.GetLength(1); j++){
            if(minJ == j){
                countJ++;
            }    
            delColArr[i,j] = delRowArr[i,countJ]; 
            countJ++;
            }
            countJ = 0;
            
    }

    for (int i = 0; i < delColArr.GetLength(0); i++)
{
                for (int j = 0; j < delColArr.GetLength(1); j++)
        {
            Console.Write($"{delColArr[i,j]} ");
        }
        Console.WriteLine();
    }


    Console.WriteLine($"{"Удалена"} {minI + 1} {"строка."}");
    Console.WriteLine($"{"Удален"} {minJ + 1} {"столбец."}");


}
Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] arr = CreateArr(row, col);
FillArr(arr);
PrintArr(arr);
Console.WriteLine();
DelArr(arr, row, col);
