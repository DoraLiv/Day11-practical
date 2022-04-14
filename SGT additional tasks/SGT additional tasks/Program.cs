// Task 1
Console.WriteLine("Task 1");
int[] Array1 = new int[10];

Console.WriteLine("Please intput 10 numbers");
Console.WriteLine("--------------------------------");
for (int i = 0; i < Array1.Length; i++)
{
    Console.Write($"Element - {i} : ");
    int.TryParse(Console.ReadLine(), out int userInput);
    Array1[i] = userInput;
}

Console.Write($"Elements in array are: ");
for (int j = 0; j < Array1.Length; j++)
{
    Console.Write($"{Array1[j]} ");
}

//Task 2
Console.WriteLine("\nTask 2");

int[] Array2 = new int[3];

Console.WriteLine("Please intput 3 numbers");
Console.WriteLine("--------------------------------");
for (int j = 0; j < Array2.Length; j++)
{
    Console.Write($"Element - {j} : ");
    int.TryParse(Console.ReadLine(), out int userInput2);
    Array2[j] = userInput2;
}

Console.WriteLine($"The values stored in array2 are:");
foreach (int i in Array2)
{
    Console.Write(i);
}

Console.WriteLine();
Console.WriteLine("The values stored in array2 in reverse are: ");
for (int i = 2; i >= 0; i--)
{
    Console.Write($"{Array2[i]}");
}

//Task3
Console.WriteLine("\nTask 3");

int sum = 0;
int[] Array3 = new int[3];

Console.WriteLine();
Console.WriteLine("Please intput 3 numbers");
Console.WriteLine("--------------------------------");
for (int i = 0; i < Array3.Length; i++)
{
    Console.Write($"Element - {i} : ");
    int.TryParse(Console.ReadLine(), out int userInput);
    Array3[i] = userInput;
}

for (int i = 0; i < Array3.Length; i++)
{
    sum += Array3[i];
}
Console.WriteLine($"The sum of all elements stored in Array3 is: {sum}");

//Task4
Console.WriteLine("\nTask 4");

int[] Array4 = new int[3];
int[] Array4a = new int[3];

Console.WriteLine();
Console.WriteLine("Please intput 3 numbers");
Console.WriteLine("--------------------------------");
for (int i = 0; i < Array4.Length; i++)
{
    Console.Write($"Element - {i} : ");
    int.TryParse(Console.ReadLine(), out int userInput);
    Array4[i] = userInput;
}

for (int i = 0; i < Array4.Length; i++)
{
    Array4a[i] = Array4[i];
}

Console.WriteLine("The elements of the first Array are:");
foreach (int i in Array4)
{
    Console.Write(i);
}
Console.WriteLine();
Console.WriteLine("The elements of the second Array are:");
foreach (int i in Array4a)
{
    Console.Write($"{i} ");
}

//Task5
Console.WriteLine("\nTask 5");

int[] ArrayA = new int[100];
int[] ArrayB = new int[100];
int[] ArrayC = new int[100];
int m = 0, counter = 0;

Console.WriteLine();
Console.WriteLine("Input the number of elements to be stored in the array: ");
int.TryParse(Console.ReadLine(), out int size);
Console.WriteLine();
Console.WriteLine($"Please intput {size} numbers");
Console.WriteLine("--------------------------------");
for (int i = 0; i < size; i++)
{
    Console.Write($"Element - {i} : ");
    int.TryParse(Console.ReadLine(), out int userInput);
    ArrayA[i] = userInput;
}

//copying the array
for (int i = 0; i < size; i++)
{
    ArrayB[i] = ArrayA[i];
    ArrayC[i] = 0;
}

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (ArrayA[i] == ArrayB[j])
        {
            ArrayC[j] = m;
            m++;
        }
    }
    m = 1;
}

for (int i = 0; i < size; i++)
{
    if (ArrayC[i] == 2)
    {
        counter++;
    }
}
Console.WriteLine($"The number of duplicates is: {counter}");

Console.WriteLine("\nTask 6");

int[] Array6 = new int[100];
Console.WriteLine();
Console.WriteLine("Input the number of elements to be stored in the array: ");
int.TryParse(Console.ReadLine(), out int n);
Console.WriteLine();
Console.WriteLine($"Please intput {n} numbers");
Console.WriteLine("--------------------------------");
for (int i = 0; i < n; i++)
{
    Console.Write($"Element - {i} : ");
    int.TryParse(Console.ReadLine(), out int userInput);
    Array6[i] = userInput;
}

for (int i = 0; i < n; i++)
{
    int ctr = 0;

    //checking if there are any identical numbers on the left
    for (int j = 0; j<i-1; j++)
    {
        if(Array6[i] == Array6[j])
        {
            ctr++;
        }
    }
    //checking if there are any identical numbers on the right
    for (int k = i + 1; k < n; k++)
    {
        if (Array6[i] == Array6[k])
        {
            ctr++;
        }
        //Duplicate numbers next to each other (why)
        if (Array6[i] == Array6[i+1])
        {
            i++;
        }
    }
    if (ctr == 0)
    {
        Console.Write($"The unique number is: {Array6[i]} ");
    }

}
