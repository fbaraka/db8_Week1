NewMethod();

static void NewMethod()
{
    /*
     * 
     * 
     * Building a console app that that will analyze a users input between 1-100
     * Conditions we are looking for are even, odd, and ranges
     * app will print out conditional results
     * 
     *
     */





    // TODO: Greet and promt the user to enter an integer between 1 and 100 
    //do
    //{

    //nsole.Write("Enter an integer between 1 and 100: ");
    //t usersInt = Convert.ToInt32(Console.ReadLine());

    //if (usersInt > 1 && usersInt < 100)
    //{
    //    Console.WriteLine("You entered " + usersInt);
    //    correctInt = true;
    //}
    //else
    //{
    //    Console.WriteLine("oops...looks like you didn't select a number between 1-100. Please try again");
    //    correctInt = false;
    //}

    /*    do
        {
            Console.Write("Enter an integer between 1 and 100: ");
            int usersInt = Convert.ToInt32(Console.ReadLine());

            // Created a nested if else statement for the conditions

            if(usersInt % 2 != 0 && usersInt < 60) // TODO: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
            {
                Console.WriteLine($"{usersInt} is Odd and less than 60.");

            }
            else if (usersInt % 2 == 0 && usersInt >= 2 && usersInt <= 25) // TODO: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
            {
                Console.WriteLine("Even and less than 25.");

            }
            else if (usersInt % 2 == 0 && usersInt >= 26 && usersInt <= 60) // TODO: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
            {
                Console.WriteLine("Even and between 26 and 60 inclusive.");

            }
            else if (usersInt % 2 == 0 && usersInt >= 60) // TODO: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
            {
                Console.WriteLine($"{usersInt} is even and greater than 60.");

            }
            else if (usersInt % 2 != 0 && usersInt > 60) // TODO: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
            {
                Console.WriteLine($"{usersInt} is odd and greater than 60");

            }
            else
            {
                Console.WriteLine("....something is wrong");

            }*/







    //while (!correctInt);    






    // BONUS: Set up the program to continue running with a prompt at the end to see if they want to stop. (hint: Loops)
    // BONUS: Add validation to guarantee that a user enters a positive integer between 1 and 100.
























    bool endProgram = false;
    bool goAgain = false;


    do
    {

        Console.Write("Enter an integer between 1 and 100: ");
        int usersInt = Convert.ToInt32(Console.ReadLine());

        bool validInt = true;

        do
        {
            if (usersInt >= 1 && usersInt <= 100)
            {
                validInt = true;
                Console.WriteLine("You entered " + usersInt);
            }
            else
            {
                Console.Write("oops, wrong number, please try again: ");
                usersInt = Convert.ToInt32(Console.ReadLine());
                validInt = false;

            }
        } while (!validInt);
        if (usersInt % 2 != 0 && usersInt < 60) // TODO: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
        {
            Console.WriteLine($"{usersInt} is Odd and less than 60.");

        }
        else if (usersInt % 2 == 0 && usersInt >= 2 && usersInt <= 25) // TODO: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
        {
            Console.WriteLine("Even and less than 25.");

        }
        else if (usersInt % 2 == 0 && usersInt >= 26 && usersInt <= 60) // TODO: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
        {
            Console.WriteLine("Even and between 26 and 60 inclusive.");

        }
        else if (usersInt % 2 == 0 && usersInt >= 60) // TODO: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
        {
            Console.WriteLine($"{usersInt} is even and greater than 60.");

        }
        else if (usersInt % 2 != 0 && usersInt > 60) // TODO: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”
        {
            Console.WriteLine($"{usersInt} is odd and greater than 60");

        }
        else
        {
            Console.WriteLine("....something is wrong");
        }

        do
        {
            Console.WriteLine("Would you like to go again? y/n : "); // Asking if the user wants to go again 
            string cont = Console.ReadLine().ToLower();

            if (cont == "y")
            {
                goAgain = true;
            }
            else if (cont == "n")
            {
                goAgain = true;
                endProgram = true;
            }
        } while (!goAgain);

    } while (!endProgram);
}





