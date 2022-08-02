// TODO: Calculate the perimeter and area of a room and then classify the room as small, medium, or large

// TODO: Prompt the user 

Console.WriteLine("Welcome to the Room Detail Generator!");
// TODO: Take user input for length and width and store them in variables 

Console.Write("Please enter the length: ");
double l = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter the width: ");
double w = Convert.ToDouble(Console.ReadLine());

// BONUS: user input for volume
Console.Write("Please enter the height: ");
double h = Convert.ToDouble(Console.ReadLine());

// TODO: calculate the area 
double area = l * w;
Console.WriteLine($"\nArea: {area} square feet");

// TODO: calculate the perimeter 
Console.WriteLine("Perimeter: " + (l + w) * 2 + " feet");

// BONUS: Calculate volume
double volume = l * w * h;
Console.WriteLine($"\nVolume: {volume} cubed feet");

// BONUS: Calculate surface area
double surfaceArea = (l*w + w*h + h*l) * 2;
Console.WriteLine($"Surface area: {surfaceArea} feet\n");

// TODO: Classify a room as small (up to and including 250 square feet), medium (more than 250 but less than 650 square feet, or large (650 square feet or more).

if (area <= 250)
{
    Console.WriteLine("This is a small-sized room.");
}
else if (area > 250 && area < 650)
{
    Console.WriteLine("This is a medium-sized room.");
}
else
{
    Console.WriteLine("This is a large-sized room.");
}

// TODO: Thank the user

Console.WriteLine("\nThank you for using the Room Detail Generator!");

// tested with decimals and it broke. changed all ints to doubles 
// still didn't work, had to change the convert.ToInt to To.Double
// adding a new line within strings is \n not /n
