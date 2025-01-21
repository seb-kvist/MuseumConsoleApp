using System;

namespace ennattpamuseet;

public class Navigation
{
    //Your current location/room
    private Room activeRoom;

public Navigation(Room room){
   this.activeRoom = room;
}
    //Konstruktor som tar lista med alla rum
   
    public Navigation(List<Room> rooms)
    {
        // Hitta "Entré" i listan över rum
        activeRoom = rooms.FirstOrDefault(r => r.Name == "Entré")
        ?? throw new InvalidOperationException("Entré-rummet kunde inte hittas.");
    }

    //Returnerar vilket rum du är i
    public Room GetActiveRoom(){
        return activeRoom;
    }

    //Byter till nytt rum om det finns
    public void SetActiveRoom(Room newRoom)
    {
        if (!activeRoom.ConnectedRooms.Contains(newRoom))
        {
            throw new InvalidOperationException($"Du kan inte flytta till rummet '{newRoom.Name}' från '{activeRoom.Name}'.");
        }

        //Byter till rummet
        activeRoom = newRoom;
    }

    public List<Room> GetAdjacentRooms()
    {
        return activeRoom.ConnectedRooms;
    }
    
}
