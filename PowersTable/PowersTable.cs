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
 * ~~~~~~~~~SAMPLE~~~~~~~~~~~~~~~~~~~~~~~~
 * 
 * Learn your squares and cubes!

Enter an integer: {user input here, for example: 5}

Number     	Squared       	Cubed
=======  	=======		    ======
1			1			    1
2			4 			    8
3         	9            	27
4      		16          	64
5           25          	125

Continue? (y/n): {user input here, for example: Y}

Enter an integer: ...
*
*
*
*
 */


bool keepGoing = true;
bool validInt = false;

Console.WriteLine("Learn your squares and cubes!");

while (keepGoing)
{
    while (!validInt)
    {
        Console.Write("Enter an integer: ");
        int userInt = Convert.ToInt32(Console.ReadLine());

        if (userInt > 0)
        {

            validInt = true;
            SquareAndCubedTable(userInt);

        }
        else
        {
            validInt = false;
            Console.WriteLine("select a positive and non zero number!");
            userInt = Convert.ToInt32(Console.ReadLine());
        }

        

        Console.WriteLine("Would you like to go again? (y/n)");
        string cont = Console.ReadLine().ToLower();

        StartOver(cont, out keepGoing);
    }

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

static void StartOver(string x, out bool keepGoing)
{

    if (x[0] == 'n')
    {
       keepGoing  = false;
    }
    else
    {
        keepGoing = true;
    }
}

