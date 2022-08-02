// Instructions: 
// Ask the user to enter a number 
// Print out hte square of the number
// Ask the user if they want to go again. They can enter y or Y to go again, n or N to quit


bool keepGoing = true;


do
{
    Console.Write("Enter a number to get squared: ");
    double entry = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"That number squared is {entry * entry}");



    // Ask the user if they want to go again and it is validating the user input too

    Console.WriteLine("Would you like to keep going? \n Enter y or n : ");
    string userInput = Console.ReadLine().ToLower;

    bool valid = false;
    do
    {

   

        if (userInput == "n" || userInput == "no")
        {
            valid = true;
            keepGoing = false;
        }
        else if (userInput == "y" || userInput == "yes" )
        {
            valid = true;
        }

    } while (valid == false);


} while (keepGoing);



