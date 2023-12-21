#region Task 1 
//*
//**
//***
//****
//*****
//******
//*******
//******** 
//*********

for (int i = 0; i < 6; i++)
{                                                      // *
    for (int j = 0; j < i; j++)                        // **
    {                                                  // ***
        Console.Write("*");                            // ****
    }                                                  // *****
    Console.WriteLine();
}

Console.WriteLine();



//* * * * * * *
//*           *
//*           *
//*           *
//*           *
//* * * * * * *


for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 7; j++)
    {
        if (i == 0 || i == 5 || j == 0 || j == 6)
        {
            Console.Write("* ");
        }
        else
        {
            Console.Write("  ");
        }
    }

    Console.WriteLine();
}
Console.WriteLine();



//*****
//*****
//*****
//*****

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
#endregion

#region Task 2
Console.WriteLine();
for (int i = 1; i <= 9; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine(new string('-', 20));
}
#endregion
