/*
* Name: Brynee Snow
* Course: CSCI 1250, Section 002
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise 
* practices decisions and one of the four loops.
*/

Random rng = new Random(4000);
int userChoice;

// do while loop because the menu and its options have to be shown before a choice can be made
do
{

System.Console.WriteLine("=== CSCI 1250 Lab 06 ===");
System.Console.WriteLine("1. The Grade Checker ");
System.Console.WriteLine("2. The Dice Table ");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three ");
System.Console.WriteLine("5. Quit");
System.Console.WriteLine("Choose a number 1 through 5");

userChoice = Convert.ToInt32(Console.ReadLine());

// while loop because we need to repeat the program until the user inputs a number 1-5

while(userChoice < 1 || userChoice > 5)
    {
        System.Console.Write("Choose a number from 1 to 5:");
        userChoice = Convert.ToInt32(Console.ReadLine());
    }
System.Console.WriteLine("");


// the while loop is being used because it is not known how many times the user will input a incorrect answer and the program needs a number 0 - 100


if(userChoice == 1 || userChoice == 4)
{
    System.Console.WriteLine("=== Exercise 1:The Grade Checker ===");
    System.Console.Write("Score:");

    double userScore = Convert.ToDouble(Console.ReadLine());

    while(userScore < 0.00 || userScore > 100.00)
        {
        System.Console.Write("Please enter a score between 0 and 100. ");
        userScore = Convert.ToDouble(Console.ReadLine());
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
        else if(userScore >= 60.00)
        {
        System.Console.WriteLine($"{userScore} earns a D");
        }
        else if(userScore < 60.00)
        {
        System.Console.WriteLine($"{userScore} earns a F");
        }
    System.Console.WriteLine("");
}

// the do while loop is being used because the player already selected to roll in the orginal menu so we need the program to run once before being asked to roll again


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
            System.Console.WriteLine("A Winner!");
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
    
    System.Console.WriteLine("");
}


if(userChoice == 3 || userChoice == 4)
{
    int [] scores = new int [5];
    int passing = 0;
    int total = 0;
    int highest = 0;

    System.Console.WriteLine("=== Exercise 3: The Score Report ===");

// the for loop because position matters, the user needs to know what score they are entering so the position in the array is correct

for(int i = 0; i < scores.Length; i++)

    {
        System.Console.Write($"Score {i + 1}: ");
        int testScore = Convert.ToInt32(Console.ReadLine());
    
    // while loop because it is important that the user inputs a valid number so the calculations are not affected

        while(testScore < 0 || testScore > 100)
        {
            System.Console.WriteLine("Please enter a number 0 through 100. ");
            testScore = Convert.ToInt32(Console.ReadLine());
        }
        
    scores[i] = testScore;

    }
   
// for each loop because there is not a need for position and all the math has to be done to every value

    foreach(int score in scores)
    {

     total += score;
    if (score > highest) highest = score;
    if (score >= 60) passing++;

}

    double average = (double)total / scores.Length;

Console.WriteLine($"Scores entered: {scores.Length}");
Console.WriteLine($"Total: {total}");
Console.WriteLine($"Average: {average:F1}");
Console.WriteLine($"Highest: {highest}");
Console.WriteLine($"Passing: {passing} of {scores.Length}");
System.Console.WriteLine("");
    }

} while(userChoice != 5);

if(userChoice == 5)
{
    System.Console.WriteLine("Goodbye.");
}