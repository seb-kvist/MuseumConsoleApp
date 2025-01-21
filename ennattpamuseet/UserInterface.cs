using System;
using System.Collections.Generic;
using ennattpamuseet;

public class UserInterface
{
    static List<Room> rooms = Room.CreateTheRooms();
    Navigation navigation = new Navigation(rooms);

    // Method to show a welcome message
    public void ShowWelcomeMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    // Method to show an error message in red color
    public void ShowErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }

    // Method to check if user input is valid
    public bool IsUserInputValid(string input, out int userChoice)
    {
        bool validInput = int.TryParse(input, out userChoice);
        return validInput;
    }

    // Dictionary to store room names with corresponding colors
    Dictionary<string, ConsoleColor> roomsColor = new Dictionary<string, ConsoleColor>
    {
        { "Vita rummet", ConsoleColor.White },
        { "Svarta rummet", ConsoleColor.Black },
        { "Lila rummet", ConsoleColor.Magenta },
        { "Blåa rummet", ConsoleColor.Blue },
        { "Röda rummet", ConsoleColor.Red },
        { "Entré", ConsoleColor.Cyan },
        { "Korridor", ConsoleColor.DarkBlue },
        { "Gröna rummet", ConsoleColor.Green }
    };

    // Method to display connected rooms with corresponding colors
    public void DisplayConnectedRoomsColor(Room room)
    {
        Console.WriteLine("\nWhere would you like to go now?");
        int num = 1;
        room.ConnectedRooms.ForEach(r =>
        {
            if (roomsColor.TryGetValue(r.Name, out ConsoleColor color))
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"\n{num}. {r.Name}");
                Console.ResetColor();
            }
            num++;
        });
        Exit();
    }

    // Method to display the current room with corresponding color
    public void DisplayMatchingRoomColor(Room room)
    {
        if (roomsColor.TryGetValue(room.Name, out ConsoleColor color))
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\nYou are now in {room.Name}.");
            Console.ResetColor();
        }
    }

    // Method to exit the program
    public void Exit()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPress 0 to exit the program.");
        Console.ResetColor();
    }

    // Method to show instructions
    public void ShowInstructions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Instructions:");
        Console.WriteLine("1. Use the numbers to move between different rooms.");
        Console.WriteLine("2. Each room may have different artworks to look at.");
        Console.WriteLine("3. Press 0 to exit the program.");
        Console.ResetColor();
    }
}