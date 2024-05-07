using System;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

{
    // Array to hold names

    string[] names = { "Justin", "Ethan", "Victoria", "Ethan", "Ben", "Kyra", "Jack", "Ramses", "Clare", "Ramsey", "Ali", "Pedro", "Mellisa" };

    // Array to hold favorite foods
    string[] favoriteFoods = { "Baja Blast", "Ethan", "Pho", "Hot Wings", "Crab legs", "Sushi", "Hot Wings", "Lasagna", "Cheesy Potatoes", "Dim Sum", "Indian", "Italian", "Pizza" };

    // Array to hold hometowns
    string[] hometowns = { "Westerville", "Ethan", "Blacksburg", "Bolivar", "Birmingham", "Hazel Park", "Trenton", "Wyoming", "Lake Orion", "Brooklyn", "Dearborn Heights", "Chicago", "Detroit" };
   

   
    Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-13");
    
    int namechoice = int.Parse(Console.ReadLine());
   
    
        if (namechoice > 13 || namechoice < 0)
        {
            Console.WriteLine("Number out of range, please enter a numbers between 0-13");
        }
        else if (0 <= namechoice && namechoice <= 13)
        {
            Console.WriteLine("Student " + namechoice + " is " + names[namechoice] + "." + " What would you like to know? Enter 'hometown' or 'favorite food'.");
        }
           



        string choice = Console.ReadLine();
        string choice1 = "hometown";
        string choice2 = "favorite food";

    if (choice == choice1)
    {
        Console.WriteLine(names[namechoice] + " is from " + hometowns[namechoice]);
    }
    else if (choice == choice2)
    {
        Console.WriteLine(names[namechoice] + " favorite food is " + favoriteFoods[namechoice]);
    }
    else 
    {
        Console.WriteLine("Invalid entry. Please try again");
    }

    Console.WriteLine("Would you like to see all the students names? 'y' or 'n'");
    string namelist = Console.ReadLine();
    string namelist1 = "y";
    string namelist2 = "n";
    if (namelist == "y")
    {
        Console.WriteLine("Student Names");
        List<string> namesList = names.ToList();
        foreach (string name in namesList)
        Console.WriteLine(name);
    }

    Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n'");
        string keepgoing = Console.ReadLine();
        string keepgoing1 = "y";
        string keepgoing2 = "n";
        if (keepgoing == keepgoing1)
        {
            for (int i = 0; i < names.Length; i++) ;
            
        }
        else if (keepgoing == keepgoing2)
        {
            Console.WriteLine("Thanks!");
        }
    
}