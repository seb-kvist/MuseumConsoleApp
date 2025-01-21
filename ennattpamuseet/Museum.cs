using System;
using ennattpamuseet;

public class Museum
{
    public Museum(string museumName)
    {
        UserInterface userInterface = new UserInterface();
        List<Room> rooms = Room.CreateTheRooms();
        Navigation navigation = new Navigation(rooms);

        userInterface.ShowWelcomeMessage($"Welcome to {museumName} Museum");
        userInterface.ShowInstructions();
        userInterface.DisplayMatchingRoomColor(navigation.GetActiveRoom());
        userInterface.DisplayConnectedRoomsColor(navigation.GetActiveRoom());

        bool isRunning = true;

        while (isRunning)
        {
            Room activeRoom = navigation.GetActiveRoom();
            Console.WriteLine("Choose a room: ");
            string input = Console.ReadLine();
            Console.Clear();

            int userChoice;
            if (userInterface.IsUserInputValid(input, out userChoice))
            {
                if (userChoice > 0 && userChoice <= activeRoom.ConnectedRooms.Count)
                {
                    navigation.SetActiveRoom(activeRoom.ConnectedRooms[userChoice - 1]);
                    userInterface.DisplayMatchingRoomColor(navigation.GetActiveRoom());
                    navigation.GetActiveRoom().DisplayArtworksInRoom();
                    userInterface.DisplayConnectedRoomsColor(navigation.GetActiveRoom());
                }
                else if (userChoice > activeRoom.ConnectedRooms.Count)
                {
                    userInterface.ShowErrorMessage($"You must choose between 0 and {activeRoom.ConnectedRooms.Count}");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(input))
                {
                    userInterface.ShowErrorMessage("You missed entering a number!");
                }
                else
                {
                    userInterface.ShowErrorMessage("You must enter a number!");
                }
            }

            if (userChoice == 0)
            {
                isRunning = false;
            }
        }
    }
}