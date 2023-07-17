Console.WriteLine("Welcome to the student database.");
Console.WriteLine();


string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] towns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "Poughkeepsie", "West bloomfield", "Rochester Hills", "Clio", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };

bool runProgram = true;
while (runProgram)
{
    int choice = 0;

    while (true)
    {
        Console.WriteLine("Would you like to see a list of all students? y/n");
        string response1 = Console.ReadLine().ToLower().Trim();
        if (response1 == "n")
        {
            break;
        }
        else if (response1 == "y")
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);                
            }
            break;
        }
        else
        {
            Console.WriteLine("Invalid answer, please enter y or n");
        }
    }

    while (true)
    {
        Console.WriteLine("Please enter a number 1 thru 11 to choose a student");
        choice = int.Parse(Console.ReadLine())-1;
        if (choice < 0 || choice > names.Length-1)
        {
            Console.WriteLine("That number is out of range. Please enter a number between 1 and 11.");
        }
        
        else
        {
            break;
        }
    }

    Console.WriteLine(names[choice]);
    
    while (true)
    {
        Console.WriteLine("Which category would you like Hometown or Favorite food?");
        string category = Console.ReadLine().ToLower().Trim();
        string choice1 = "hometown";
        string choice2 = "favorite food";
        string choice3 = "food";
        string choice4 = "town";

        if (category == choice1)
        {
            Console.WriteLine(towns[choice]);
            break;
        }

        else if (category == choice2)
        {
            Console.WriteLine(foods[choice]);
            break;
        }
        else if (category == choice3)
        {
            Console.WriteLine(foods[choice]);
            break;
        }
        else if (category == choice4)
        {
            Console.WriteLine(towns[choice]);
            break;
        }
        else
        {
            Console.WriteLine("Invalid response, please try again.");
        }
    }

    while (true)
    {
        Console.WriteLine("Would you like to learn about another student y/n?");
        string response = Console.ReadLine().ToLower().Trim();

        if (response == "n")
        {
            Console.WriteLine("Goodbye");
            runProgram = false;
            break;
        }
        else if (response == "y")
        {
            runProgram = true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid answer, please enter y or n");
        }
    }
    
}