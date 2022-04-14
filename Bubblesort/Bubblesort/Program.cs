int[] numbersToSort = new int[] { 23, 45, 100, 3, 24 };
int temp = 0;

for (int i = 0; i < numbersToSort.Length; i++)
{
    for (int j = 0; j < numbersToSort.Length - 1; j++) 
    {
        if (numbersToSort[j] > numbersToSort[j + 1])
        {
            temp = numbersToSort[j + 1];
            numbersToSort[j + 1] = numbersToSort[j];
            numbersToSort[j] = temp;
        }
    }
}

foreach (int i in numbersToSort)
{
    Console.Write($"{i}; ");
}