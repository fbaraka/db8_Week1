//added some pausing that I thought was cool with Al's code with Thread.Sleep();

// Bool for asking the usuer if they want to go again 
bool keepGoing = true;

// TODO: take in user input for dice sides 

Console.WriteLine("Welcome to DevBuild Dice Roller!\n");
Console.Write("How many sides should each side have for the two dice? \nEnter your number right here: ");

int diceSides = Convert.ToInt32(Console.ReadLine());
int rollCount = 1; // going to try and increment this to print a roll count each time

Console.WriteLine(); // just for spacing

while (keepGoing)
{
    // Prompt user to roll dice
    Console.Write("Roll dice? y/n: ");
    // Storing user's choice 
    string userRollChoice = Console.ReadLine().ToLower();

    // make the two dice variables 
    int dice1 = MakeRandomNum(diceSides); 
    int dice2 = MakeRandomNum(diceSides);
    Console.Write("Rolling...\n");
    Thread.Sleep(1000);

    // Logic to roll dice and see if we have 6 sided dice or another numbered dice 
    if (userRollChoice[0] == 'y' && diceSides == 6)
    {
        Console.WriteLine($"\n\tRoll # {rollCount}:");
        Console.WriteLine(RollingSixSidedDice(dice1, dice2)); // 6 sided dice function
        rollCount++;
    }
    else if (userRollChoice[0] == 'y')
    {
        Console.WriteLine($"\nRoll # {rollCount}:");
        RollingDice(dice1, dice2); // other dice function
        rollCount++;
    }
    else
    {
        Console.WriteLine("\nThank you for using the devBuild Dice Roller!");
        keepGoing = false;
    }
}



// Create a function to make a random num below. Pass through the user input of dice sides 

static int MakeRandomNum (int diceSides)
{
    Random rand = new Random(); // making an instance of Random to use later
    return rand.Next(1, diceSides + 1 ); // 1 is always the default and diceSides +1 will make the users choice inclusive
}

static void RollingDice(int dice1, int dice2)
{
    Console.WriteLine($"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n");
}

static string RollingSixSidedDice(int dice1, int dice2)
{
    int diceTotal = dice1 + dice2;

    string result;

    if (diceTotal == 2)
    {
       return result = $"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n\n\tSnake Eyes!\n\tCraps!\n";
    }
    else if (dice1 == 6 && dice2 == 6)
    {
        return result = $"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n\n\tBox Cars!\n\tCraps!\n";
        
    }
    else if (diceTotal == 3)
    {
        return result = $"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n\n\tAce Deuce!\n\tCraps!\n";
       
    }
    else if (diceTotal == 7 || diceTotal == 11)
    {
        return result = $"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n\n\tYou win!\n";
      
    }
    else if (diceTotal == 12)
    {
        return result = $"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n\n\tCraps!\n";
        
    }
    else
    {
        return result = $"\n\tYou rolled a {dice1} and a {dice2} ({dice1 + dice2} total)\n";
    }

}




