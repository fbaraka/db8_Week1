/*
 * 
 * Display a table of powers. Ask the user if they would like to go again, and if so loop back to the beginning.
 * 
 * The application prompts the user to enter an integer.
 * The application displays a table of squares and cubes from 1 to the value entered.
 * The application prompts the user to continue.
 * Use \t to tab to line up columns properly
 * 
 * ~~~~~~~~~~~~~~~~BONUS~~~~~~~~~~~~~~~~~~~~~ 
 * 
 * Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
 * Research formatted strings and right-align the numbers in columns instead of left-aligning them
 * Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less
 * 
*/


bool keepGoing = true;
int userInt = 0;
Console.WriteLine("Learn your squares and cubes!");

while (keepGoing)
{
    bool validInt = false;
    Console.Write("Enter an integer: ");
    ValidateInput(ref userInt, ref validInt);
    SquareAndCubedTable(userInt);
    keepGoing = StartOver();
}





static void SquareAndCubedTable (int x)
{
    Console.WriteLine("Number\t\t\tSquared\t\t\tCubed");
    Console.WriteLine("=======\t\t\t=======\t\t\t=======");

    for (int i = 1; i <= x; i++)
    {
        Console.WriteLine($"{i}\t\t\t{i * i}\t\t\t{i * i * i}");
    }
}

static bool StartOver()
{

    Console.WriteLine("Would you like to go again? (y/n)");
    string cont = Console.ReadLine().ToLower();

    if (cont[0] == 'n')
    {
       return false;
    }
    else
    {
        return true;
    }
}

static void ValidateInput(ref int userInt, ref bool validInt)
{
    while (!validInt)
    {
        Console.Write("Enter an integer: ");
        userInt = Convert.ToInt32(Console.ReadLine());

        if (userInt > 0)
        {

            validInt = true;

        }
        else
        {
            Console.WriteLine("select a positive and non zero number!");
        }

    }
}