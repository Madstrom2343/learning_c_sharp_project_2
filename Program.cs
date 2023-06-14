// See https://aka.ms/new-console-template for more information

// Variables are like containers, you can store info into it, & grab it whenever to change it or use it
// There are different types of Variables, that can only hold a certain type of info
// There are many types of variables, but here are the four main ones:

//int - stores whole numbers
//float - stores decimal numbers, but can only hold 7 digits (double holds 16)
//string - stores text. Can store numbers & symbols, but is read as text
//boolean - simplest variable; True or False

// The main way to write a function is:
// [type](or can put var for unsure/lazy) - [name] "=" - [value] ;
// exp. var myAge = 22; 

// Asks for name
Console.WriteLine("What's your name?");

// Variable is made called userName. the info will be whatever input the user types
string userName = Console.ReadLine();

// The terminal will use what input the user put for their name as what they said
Console.WriteLine("Hello " + userName + ", it's nice to meet you!");


// Next Challenge: Creating a simple calculator
Console.WriteLine("\n \n \n");

// Here are two int variables that are not stored with anything or used yet
int num01;
int num02;

Console.Write("Please give me a *whole* number: ");

// The first int variable first converts the string input of the user to an int & stores it in the variable
num01 = Convert.ToInt32( Console.ReadLine() );

Console.Write("Awesome, please give me one more *whole* number: ");

// The same is done with the second int variable, turned from string to int, then stored
num02 = Convert.ToInt32( Console.ReadLine() );


// A new int is made, becomming the sum of num01 & num02 added together
int result = num01 + num02;
// + for addition, - for subtraction, * for multiplication, / for division

// the terminal gives the user the two inputs they gave, and also gives the added sum of those numbers
Console.WriteLine("Oki doki " + userName + ", "+num01 + " and " + num02 + " make " + result + " when added!");


// Next Challenge: Finding an average from user input
Console.WriteLine("\n \n \n");

double avg01;
double avg02;
double avg03;

Console.Write("Alrighty " + userName + ", Im gonna give you the Average of three numbers. \nPlease give me your first number:");

avg01 = Convert.ToDouble( Console.ReadLine() );

Console.Write("Oki doki, please give me your second number:");

avg02 = Convert.ToDouble( Console.ReadLine() );

Console.Write("Nearly there! Please give me your third number:");

avg03 = Convert.ToDouble( Console.ReadLine() );


Double averageNumber = (avg01 + avg02 + avg03)/3;

Console.WriteLine("Okay " + userName + ", so the average of " + avg01 + ", " + avg02 + ", and " + avg03 + ", is " + averageNumber +"!");

// waits for an input before closing
Console.ReadKey();