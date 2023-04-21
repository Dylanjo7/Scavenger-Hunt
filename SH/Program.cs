// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

string input;
string answer1 = "august";
string answer21 = "environment";
string answer22 = "economy";
string answer23 = "society";
string answer3 = "alberta";
string answer41 = "elder wayne scott";
string answer42 = "elderwaynescott";
string answer43 = "wayne scott";
string answer44 = "wayne";
string answer5 = "turtle";
string guess;
int numGuesses = 0;
int numGuesses2 = 0;
int numGuesses3 = 0;
int numGuesses4 = 0;
int numGuesses5 = 0;


Console.WriteLine("Welcome To The Scavenger Hunt \nPlease go to TRCM.ca \nGo to teachers reasources, it's in teach \nPress enter to continue");
Console.ReadLine();
Console.Clear();
do
{
    Console.WriteLine("What month was the 2021 Treaty Education Summer Institute?");
    input = Console.ReadLine();
    numGuesses++;
    if (input.ToLower() == answer1)
    {
        Console.Clear();
        Console.WriteLine("Congrats! Next Question!");
        break;
    }
    else if (numGuesses == 1)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: It's in navigating the numbered treaty’s");
    }
    else if (numGuesses == 2)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: It is on page 2");
    }
    else if (numGuesses == 3)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: It is in the grey");
    }
    else if (numGuesses == 4)
    {
        Console.Clear();
        Console.WriteLine("The answer is: " + answer1);
    }

} while (input.ToLower() != answer1);

do
{
    Console.WriteLine("Go back a page and go in celebrating treaties, list one of the three pillars of sustainability:");
    input = Console.ReadLine();
    numGuesses2++;
    if (input.ToLower() == answer21 || input.ToLower() == answer22 || input.ToLower() == answer23)
    {
        Console.Clear();
        Console.WriteLine("Congrats! Next Question!");
        break;
    }
    else if (numGuesses2 == 1)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: page 52");
    }
    else if (numGuesses2 == 2)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: What are inside the circular arrows?");
    }
    else if (numGuesses2 == 3)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nDo ctrl F to search for pillars \n(it is the fourth one)");
    }
    else if (numGuesses2 == 4)
    {
        Console.Clear();
        Console.WriteLine("One of the answers are: " + answer21);
    }


} while (input.ToLower() != answer21 || input.ToLower() != answer22 || input.ToLower() != answer23);
do
{
    Console.WriteLine("Go to the discover tab in education \nWhat province is treaty 7 in?");
    input = Console.ReadLine();
    numGuesses3++;
    if (input.ToLower() == answer3)
    {
        Console.Clear();
        Console.WriteLine("Congrats! Next Question!");
        break;
    }
    else if (numGuesses3 == 1)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: Click the link in the red");
    }
    else if (numGuesses3 == 2)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: It is in Historical Treaties of Canada");
    }
    else if (numGuesses3 == 3)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: It is on the left side of Canada");
    }
    else if (numGuesses3 == 4)
    {
        Console.Clear();
        Console.WriteLine("The answer is: " + answer3);
    }

} while (input.ToLower() != answer3);
do
{
    Console.WriteLine("Go to the discover tab in education \nWho wrote the following quote? \n\n'As long as the sun\nshines, grass grows,\nand the waters flow.\nThat’s Eternal Law.'\n");
    input = Console.ReadLine();
    numGuesses4++;
    if (input.ToLower() == answer41 || input.ToLower() == answer42 || input.ToLower() == answer43 || input.ToLower() == answer44)
    {
        Console.Clear();
        Console.WriteLine("Congrats! Next Question!");
        break;
    }
    else if (numGuesses4 == 1)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: Click on the TRCM Brochure Map");
    }
    else if (numGuesses4 == 2)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: It is in the red");
    }
    else if (numGuesses4 == 3)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: The quote is on the right side in the yellow");
    }
    else if (numGuesses4 == 4)
    {
        Console.Clear();
        Console.WriteLine("One of the answers is: " + answer41);
    }

} while (input.ToLower() != answer41 || input.ToLower() != answer42 || input.ToLower() != answer43 || input.ToLower() != answer44);
do
{
    Console.WriteLine("Go back a page and go to the page that rhymes with enrage in education tab \nWhat animal is on screen in kinikinik at 1:12?");
    input = Console.ReadLine();
    numGuesses5++;

    if (input.ToLower() == answer5)
    {
        Console.Clear();
        Console.WriteLine("Congrats! you WIN!!!!!");
        break;
    }
    else if (numGuesses5 == 1)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: Watch the video near the bottom of the page.");
    }
    else if (numGuesses5 == 2)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: Listen to what the animal says.");
    }
    else if (numGuesses5 == 3)
    {
        Console.Clear();
        Console.WriteLine("You're wrong \nHeres a Hint: Turn on captions so you can read what the animal says.");
    }
    else if (numGuesses5 == 4)
    {
        Console.Clear();
        Console.WriteLine("The answer is: " + answer5);
    }
   

} while (input.ToLower() != answer5);

