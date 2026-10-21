using Microsoft.VisualBasic;

Random rng = new Random(4000);


System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker ");
System.Console.WriteLine("2. The Dice Table ");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three ");
System.Console.WriteLine("5. Quit");
System.Console.Write("Choose a number 1 through 5:");

int userChoice = Convert.ToInt32(Console.ReadLine());

// the while loop is being used because 


if(userChoice == 1 || userChoice == 4)
{
    System.Console.WriteLine("=== Exercise 1:The Grade Checker ===");
    System.Console.Write("Score:");

    double userScore = Convert.ToDouble(Console.ReadLine());

    while(userScore < 0.00 || userScore > 100.00)
        {
        System.Console.Write("Please enter a score between 0 and 100. ");
        userScore = Convert.ToInt32(Console.ReadLine());
        }

        if(userScore >= 90.00)
        {
            System.Console.WriteLine($"{userScore} earns an A");
        }

        else if(userScore >= 80.00)
        {
            System.Console.WriteLine($"{userScore} earns a B");
        }
        else if(userScore >= 70.00)
        {
        System.Console.WriteLine($"{userScore} earns a C");
        }
        else if(userScore > 60.00)
        {
        System.Console.WriteLine($"{userScore} earns a D");
        }
        else if(userScore <= 60.00)
        {
        System.Console.WriteLine($"{userScore} earns a F");
        }
    
}

// the do loop is being used because 


if(userChoice == 2 || userChoice ==4)
{
    int win = 0;
    int roll = 0;
    char rollAgain;

    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    do
    {
    int dice1 = rng.Next(1,7);
    int dice2 = rng.Next(1,7);
    int diceTotal = dice1 + dice2;
    roll++;

    System.Console.Write($"Roll {roll}: {dice1} and {dice2}, total {diceTotal}. ");

    if(dice1 == 1 && dice2 == 1)
        {
            System.Console.WriteLine("Snake Eyes!");
        }
    else if(dice1 == dice2)
        {
            System.Console.WriteLine("Doubles!");
        }
    else if(diceTotal == 7 || diceTotal == 11)
        {
            System.Console.WriteLine("Winner!");
            win++;
        }
    else
        {
            System.Console.WriteLine(" ");
        }
    
    System.Console.Write("Would you like to roll again? (y/n)");
    rollAgain = Console.ReadLine().ToLower()[0];
    
    }while(rollAgain == 'y');

    System.Console.WriteLine($"You rolled {roll} times and won {win}");
}

// the for loop is being used because 

if(userChoice == 3 || userChoice == 4)
{
    System.Console.WriteLine("=== Exercise 3: The Score Report ===");
}