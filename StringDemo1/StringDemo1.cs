string name = "Fred";
Console.WriteLine(name);

string upperName = name.ToUpper(); // all string are immutable in c#
Console.WriteLine(upperName);
Console.WriteLine(name);

Console.WriteLine(name[0]);
Console.WriteLine(name[1]);

// Floating Point types
// two types of floating types 

double pi = 3.1415926;
Console.WriteLine(pi);

// float n = 3.1415926f; We rarely use float these days. Put an F or f after it to initialize it. 

// When we are working with money, we don't use float or double 
// we use decimal!
// have to put an m to initialize the decimal variable 

decimal amount = 99.95m;
Console.WriteLine(amount);
amount = amount * 2;
Console.WriteLine(amount);

bool passed = false;
Console.WriteLine(passed);

passed = !passed; // ! means not. can flip booleans 

Console.WriteLine(passed);

