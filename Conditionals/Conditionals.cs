//Console.WriteLine("What is your name?");
//string entry = Console.ReadLine();
//Console.WriteLine(entry);

string entry = Console.ReadLine();
int n = int.Parse(entry);

if ( n > 50 ) // Statement: n is greater than 50
{
    Console.WriteLine("Yes, n is greater than 50");
    Console.WriteLine($"n is {n}"); // money sign before the string symbol " will allows us to interpolate variable into the string
}
else
{
    Console.WriteLine("No, n is not greather than 50");
    Console.WriteLine($"n is {n}");
}


// Let's see if the number is between 3 and 10 exclusive ( does not include the endpoints) 

if (    (n>3) && (n<10)) // a condition for a range of values between 3 and 10
{
    Console.WriteLine("Yes, n is between 3 and 10");
}
else
{
    Console.WriteLine("No, n is not between 3 and 10");
}

// Let's see if the number is between 3 and 10 inclusive (includes the end points)

if ((n >= 3) && (n <= 10)) 
{
    Console.WriteLine("Yes, n is between 3 and 10");
}
else
{
    Console.WriteLine("No, n is not between 3 and 10");
}
