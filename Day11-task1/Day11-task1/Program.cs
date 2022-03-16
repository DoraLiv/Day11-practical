// Task 1 by Dora

for (int i = 0; i <30; i++) 
{ 
    if (i % 2 !=0) 
    { 
        Console.Write($"{i}  "); 
    } 
}

Console.WriteLine("\n");

// Task 2 by Olga
int Min = -10;
int Max = 100;

int[] anyArray = new int[5];
Random random = new Random();

for (int i = 0; i < anyArray.Length; i++)
{
    anyArray[i] = random.Next(Min, Max);
    Console.WriteLine(anyArray[i]);
}

Console.WriteLine();

// Task 3 by Maija
int[,] array2D = new int[5, 4];

Random randomNumb = new Random();

for (int row = 0; row < array2D.GetLength(0); row++)
{
    for (int column = 0; column < array2D.GetLength(1); column++)
    {
        array2D[row, column] = randomNumb.Next(1, 1000);
        Console.Write($"{array2D[row, column]}  ");
    }
    Console.WriteLine();
}