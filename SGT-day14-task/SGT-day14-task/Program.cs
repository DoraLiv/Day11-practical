using System.Text.RegularExpressions;

string[] cities = { "Copenhagen", "Paris", "Tokyo", "Bristol", "Mumbai", "Dehli", "Riga", "Vienna", "Warsaw", "Hamburg", "Cesis", "Regina" };

bool menuOn = true;
while (menuOn)
{

    Console.WriteLine("Please choose the serach parameter:");
    Console.WriteLine("1. Search by first letter");
    Console.WriteLine("2. Search by last letter");
    Console.WriteLine("3. Search by the number of letters");
    Console.WriteLine("4. Partial search");
    Console.WriteLine("* Quit search");

    string choise = Console.ReadLine();
    int cCount = 0;


    switch (choise)
    {
        case "1":

            Console.WriteLine("Please insert the first letter:");
            char.TryParse(Console.ReadLine(), out char firstletter);
            Regex re = new Regex($"^{firstletter}", RegexOptions.IgnoreCase);
            for (int i = 0; i < cities.Length; i++)
                if (re.IsMatch(cities[i]))
                {
                    Console.WriteLine(cities[i]);
                    cCount++;

                }
            if (cCount == 0)
            {
                Console.WriteLine("There are no matches for your search.");
            }
            break;
        case "2":
            Console.WriteLine("Please insert the last letter:");
            char.TryParse(Console.ReadLine(), out char lastletter);
            Regex re2 = new Regex($"{lastletter}$", RegexOptions.IgnoreCase);
            for (int i = 0; i < cities.Length; i++)
                if (re2.IsMatch(cities[i]))
                {
                    Console.WriteLine(cities[i]);
                    cCount++;

                }
            if (cCount == 0)
            {
                Console.WriteLine("There are no matches for your search.");
            }
            break;
        case "3":
            Console.WriteLine("Enter the number of letters:");
            int.TryParse(Console.ReadLine(), out int letters);
            Regex re3 = new Regex($"^[a-zA-Z]{{{letters}}}$");
            for (int i = 0; i < cities.Length; i++)
                if (re3.IsMatch(cities[i]))
                {
                    Console.WriteLine(cities[i]);
                    cCount++;

                }
            if (cCount == 0)
            {
                Console.WriteLine("There are no matches for your search.");
            }
            break;
        case "4":
        case "12":
            Console.WriteLine("Please insert the first letter:");
            string firstletter3 = Console.ReadLine();
            char first = firstletter3[0];
            Console.WriteLine("Please insert the last letter:");
            string lastletter3 = Console.ReadLine();

            Regex re5 = new Regex($"^{first}.*{lastletter3}$", RegexOptions.IgnoreCase);
            for (int i = 0; i < cities.Length; i++)
                if (re5.IsMatch(cities[i]))
                {
                    Console.WriteLine(cities[i]);
                    cCount++;

                }
            if (cCount == 0)
            {
                Console.WriteLine("There are no matches for your search.");
            }
            break;

        case "123":
            Console.WriteLine("Please insert the first letter:");
            string firstletter2 = Console.ReadLine();
            Console.WriteLine("Please insert the last letter:");
            string lastletter2 = Console.ReadLine();
            Console.WriteLine("Enter the number of letters:");
            int.TryParse(Console.ReadLine(), out int letters2);
            Regex re4 = new Regex($"^{firstletter2}[a-z]{{{letters2-2}}}{lastletter2}$", RegexOptions.IgnoreCase);
            for (int i = 0; i < cities.Length; i++)
                if (re4.IsMatch(cities[i]))
                {
                    Console.WriteLine(cities[i]);
                    cCount++;

                }
            if (cCount == 0)
            {
                Console.WriteLine("There are no matches for your search.");
            }
            break;


        case "*":
            menuOn = false;
            break;
    }
}


