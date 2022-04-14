using System.Text;
using System.Text.RegularExpressions;

string[] StrArray = { "Copenhagen", "Pacris", "Tokyo", "Bristol", "Mumbai", "Delhi", "Riga", "Vienna", "Warsaw", "Hamburg", "Cesis" };

for(int i = 0; i < StrArray.Length; i++)
{
    for(int j = 0; j<StrArray[i].Length; j++)
    {
        if(StrArray[i][j] == 'c' || StrArray[i][j] == 'C')
        {
            Console.WriteLine($"This word has c in it {StrArray[i]}");
        }
    }
}

Regex re = new("^C");
Regex re2 = new(pattern: "i$");
Regex re3 = new("^.{10}$");
Regex re4 = new("[e]", RegexOptions.IgnoreCase);
Regex re5 = new("(en)", RegexOptions.IgnoreCase);
int count1=0, count2=0, count3=0, count4=0, count5=0;

Console.Write("This word has starts with a C in it: ");
for (int i = 0; i < StrArray.Length; i++)
{
    if (re.IsMatch(StrArray[i]))
    {
        Console.Write($"{StrArray[i]} ");
        count1++;
    }
}
Console.WriteLine($"\nThe number of cities which start with a C is: {count1}");

Console.WriteLine("\n");
Console.Write("This word has ends with an i in it: ");
for (int i = 0; i < StrArray.Length; i++)
{
    if (re2.IsMatch(StrArray[i]))
    {
        Console.Write($"{StrArray[i]} ");
        count2++;
    }
}
Console.WriteLine($"\nThe number of cities which start with a I is: {count2}");

Console.WriteLine("\n");
Console.Write("These words are five characters long: ");
for (int i = 0; i < StrArray.Length; i++)
{
    if (re3.IsMatch(StrArray[i]))
    {
        Console.Write($"{StrArray[i]} ");
        count3++;
    }
}
Console.WriteLine($"\nThe number of cities are five characters long: {count3}");
Console.WriteLine("\n");

Console.Write("These words that contain the character e: ");
for (int i = 0; i < StrArray.Length; i++)
{
    if (re4.IsMatch(StrArray[i]))
    {
        Console.Write($"{StrArray[i]} ");
        count4++;
    }
}
Console.WriteLine($"\nThe number of cities that contain the character e: {count4}");
Console.WriteLine("\n");

Console.Write("These words that contain the character en: ");
for (int i = 0; i < StrArray.Length; i++)
{
    if (re5.IsMatch(StrArray[i]))
    {
        Console.Write($"{StrArray[i]} ");
        count5++;
    }
}
Console.WriteLine($"\nThe number of cities that contain the character en: {count5}");
Console.WriteLine("\n");

string txt = "Lorem ipsum dolor sit amet (ipsum), consectetur adipiscing elit ipsum, sed do eiusmod tempor magna aliqua.";
Console.WriteLine(txt);
Console.Write("The Index at which impsum starts is: ");
Console.WriteLine(txt.IndexOf("ipsum"));
Console.WriteLine();

string sample = "Aa kiu, I swd skieo 236587. GH kiu: sieo?? 25.33";
int leng = sample.Length;
int count = 0, countNr = 0, countsp = 0, special = 0;
int i2 = 0;
while (i2 < leng)
{
    if ((sample[i2] >= 'a' && sample[i2] <= 'z') || (sample[i2] >= 'A' && sample[i2] <= 'Z'))
    {
        count++;
    }
    else if (sample[i2] >= '0' && sample[i2] <= '9')
    {
        countNr++;
    }
    else if (sample[i2] == ' ')
    {
        countsp++;
    }
    else
    {
        special++;
    }
    i2++;
}
Console.WriteLine(sample);
Console.WriteLine($"The number of letters is: {count}");
Console.WriteLine($"The number of numbers is: {countNr}");
Console.WriteLine($"The number of spaces is: {countsp}");
Console.WriteLine($"The number of special characters is: {special}");


string input = Console.ReadLine();
byte[] asciiBytes = Encoding.ASCII.GetBytes(s: input);
foreach (byte b in asciiBytes)
{
    Console.WriteLine(b);
}