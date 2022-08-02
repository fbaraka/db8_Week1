// For loop 

for (int index = 0; index < 10; index++)
{
    Console.WriteLine(index);
}

Console.WriteLine("All done!\n");


for (int index = 0; index < 10; index += 2)
{
    Console.WriteLine(index);
}

Console.WriteLine("All done!\n");

for (int index = 21; index >= 0; index -= 3)
{
    Console.WriteLine(index);
}

Console.WriteLine("All done. On to While Loops \n");


//While Loop

int w = 1;

while (w < 5)
{
    Console.WriteLine("inside while loop");
    Console.WriteLine(w);
    w++;
}


// Example of a break statement inside a while (true)
Console.WriteLine();
int w2 = 9;

while (w2 >= 0)
{
    if (w2 == 4)
    {
        Console.WriteLine("oops, found corrupted data");
        break;
    }
    Console.WriteLine(w2);
    w2--;
}

Console.WriteLine("Finished with while loops and into Do While Loops\n");

int w3 = 0;
do
{
    Console.WriteLine(w3);
    w3++;
}
while (w3 < 10);

Console.WriteLine("All done with While Loops! Now a nested for loop \n");

for (int x = 1; x <= 5 ; x++)
{
    Console.WriteLine($"Starting outer loop. x is {x}");

    for (int y = 0; y <=3; y++)
    {
        Console.WriteLine($"x: {x}   y:{y}");
    }
    Console.WriteLine();
}

Console.WriteLine("How about a clock! \n");

for (int hour = 0; hour <= 24; hour++)
{
    Console.WriteLine($"The hour is {hour}");

    for (int minute = 0; minute < 60; minute++)
    {
        Console.WriteLine($"    {hour}:{minute}");
    }
}



