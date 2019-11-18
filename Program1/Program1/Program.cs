//Grading ID: X2813
//Due: 02/13/2018
//Program 1
//CIS199 - 02
//This program takes user input for parameter of a wall, height of the wall, number of windows, and doors.
//then it tells you how many gallons of paint you will need to buy, and how much it is going to cost you.

using System;
using static System.Console;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimeter, //Add the length of all the walls to get this number.
                   height, //Height of the wall.
                   costPerGallon, //How much each gallon of paint cost.
                   num1, //Variable that holds a number when doing the math
                   num2, //holds another number when doing the math.
                   minGallons; //Number of gallons needed after we take the windows and doors away.
            int numberOfDoors, //Number of doors.
                numberOfWindows, //Number of doors.
                numberOfCoats, //How many coats are you going to apply.
                gallonsToBuy;  //Gallons rounded up, this is how many gallons you should buy.
            const int DOOR_TWENTY = 20, //Constant holding how much to take for each door.
                      WINDOW_FIFTEEN = 15, //Constant holding how much to take for each window.
                      CAN_OF_PAINT = 375; //Constant holding how much a can of paint would usually cover.
            
            //Where the user inputs all the data.
            WriteLine("Welcome to the Handy-Dandy Paint Estimator");
            Write("\nEnter the total length of all walls (in feet): ");
            perimeter = double.Parse(ReadLine());
            Write("Enter the height of the walls (in feet): ");
            height = double.Parse(ReadLine());
            Write("Enter the number of doors (non-neg int): ");
            numberOfDoors = int.Parse(ReadLine());
            Write("Enter the number of windows (non-neg int): ");
            numberOfWindows = int.Parse(ReadLine());
            Write("Enter the number of coats of paint (non-neg int): ");
            numberOfCoats = int.Parse(ReadLine());
            Write("Enter the cost per gallon of paint (in $): ");
            costPerGallon = double.Parse(ReadLine());
            WriteLine(); //For spacing.

            //Math
            num1 = (perimeter * height) - ((numberOfDoors * DOOR_TWENTY) + (numberOfWindows * WINDOW_FIFTEEN));
            num2 = num1 * numberOfCoats;
            minGallons = num2 / CAN_OF_PAINT;
            gallonsToBuy = (int)Math.Ceiling(minGallons);

            //Output
            WriteLine($"You need a minimum of {minGallons:f1} gallons of paint.");
            WriteLine($"You'll need to buy {gallonsToBuy} gallons, though,\nat a cost of {(gallonsToBuy * costPerGallon):C}.");


        }
    }
}
