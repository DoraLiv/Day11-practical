string userInput;
int inputLength = 0;

Console.Write("Input the string : ");
userInput = Console.ReadLine();
Console.Write($"The string you entered is : {userInput}\n");

foreach (char chr in userInput)
{
    inputLength ++;
}

Console.WriteLine($"Length of the string is: {inputLength}");

Console.Write("he characters of the string in reverse are: \n");
while(inputLength > 0)
{
    Console.Write($"{userInput[inputLength - 1]} ");
    inputLength--;
}

