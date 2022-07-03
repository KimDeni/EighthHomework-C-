int [,,] CreateArr (int x, int y, int z)
{
    return new int [x,y,z];
}

void FillArr(int [,,] arr, int x, int y, int z)
{   
    int[] tempArr = new int [x*y*z];
    tempArr[0] =  new Random().Next(10,100);
    int counter = 0;

    for (int i = 1; i < tempArr.Length; i++){

        tempArr[i] = new Random().Next(10,100);

            for(int j = 0; j < i; j++){
                if(tempArr[i] == tempArr[j]){
                    i--;
                }
            }
        }    

    for (int i = 0; i < arr.GetLength(0); i++){

        for (int j = 0; j < arr.GetLength(1); j++){

            for (int k = 0; k < arr.GetLength(2); k++){

                arr[i,j,k] = tempArr[counter];
                counter++;
            }
        }
    }
}

void PrintArr(int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.WriteLine($"{i} {j} {k} {arr[i,j,k]} ");;
            }
        }
    }
}

Console.WriteLine("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту массива: ");
int hei = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ширину массива: ");
int wid = Convert.ToInt32(Console.ReadLine());

int[,,] arr = CreateArr(len, hei, wid);
FillArr(arr, len, hei, wid);
PrintArr(arr);




