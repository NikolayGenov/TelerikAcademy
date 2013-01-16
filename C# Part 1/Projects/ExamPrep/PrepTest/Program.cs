
using System;
class PrepTest
{   const int i = 5;
static void Main()
{
    int result = 1;
    for (int i = 1; i < 1<<5; i++)
    {
        result += i;
    }
    Console.WriteLine(result);
}
}

