using System;
using System.Net.NetworkInformation;
namespace ennattpamuseet.UnitTests;

public class NavigatonTests
{ 
    [Fact]
    public void StartPositionEntrance()
    {
        // Arrange
        var rooms = Room.CreateTheRooms(); 
        var navigation = new Navigation(rooms);
            
        // Act
        var currentRoomName = navigation.GetActiveRoom().Name;

        // Assert
        Assert.Equal("Entré", currentRoomName);
        }

    [Fact]
    public void ChangeRoom()
    {
        // Arrange
        var rooms = Room.CreateTheRooms();
        var navigation = new Navigation(rooms);
        var korridor = rooms.First(r => r.Name == "Korridor");

        // Act
        navigation.SetActiveRoom(korridor);
        var currentRoomName = navigation.GetActiveRoom().Name;

        // Assert
        Assert.Equal("Korridor", currentRoomName);
        }

    [Fact]
    public void InvalidRoom()
     {
        // Arrange
        var rooms = Room.CreateTheRooms(); 
        var navigation = new Navigation(rooms);
        var invalidRoom = new Room("Rummet finns inte");

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => navigation.SetActiveRoom(invalidRoom));
        }

    [Fact]
    public void AdjacentRooms()
    {
        // Arrange
        var rooms = Room.CreateTheRooms();
        var navigation = new Navigation(rooms);
        var entréRoom = rooms.First(r => r.Name == "Entré");

        // Act
        var adjacentRooms = navigation.GetAdjacentRooms();
        var adjacentRoomNames = adjacentRooms.Select(r => r.Name).ToList();

        // Assert
        Assert.Contains("Korridor", adjacentRoomNames); 
    }
    
}
