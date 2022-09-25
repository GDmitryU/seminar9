// Задача 60. ...Сформируйте трёхмерный массив 
//из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
void FillArray(int[,,] array)
{
    Random random = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int layers = array.GetLength(2);
    int first = random.Next(10, 15);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for(int k = 0; k < layers; k++)
        
            {
                first+=random.Next(1, 5);
                array[i, j, k] = first;
            }
        }
    }
}
void PrintArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int layers = array.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for(int k = 0; k < layers; k++)
        
            {
                string result=String.Format("({0},{1},{2})",i,j,k);
                Console.Write($"{array[i, j, k]}"+result+ "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите количество строк ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите количество слоёв ");
int layers = int.Parse(Console.ReadLine());
int[,,] array = new int[rows, columns,layers];
FillArray(array);
PrintArray(array);
