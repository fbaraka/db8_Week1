Random ran = new Random();

for (int i = 0; i < 50; i++)
{
    int num = ran.Next(1, 7);
    Console.WriteLine(num);
}