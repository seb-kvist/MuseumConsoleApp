namespace ennattpamuseet.UnitTests;

public class UnitTest1
{
    [Fact]
    public void CheckIfAllRoomsAreCreatedTest()
    {
        //Arrange (skapar en lista med alla rummens korrekta namn)
        var expectedRoomNames = new []
        {
            "Entré", 
            "Korridor", 
            "Gröna rummet", 
            "Röda rummet", 
            "Lila rummet", 
            "Blåa rummet", 
            "Svarta rummet", 
            "Vita rummet"
        };

        //Act (kallar på metoden för att skapa rummen)
        var rooms = Room.CreateTheRooms();

        //Assert (kollar så alla rum skapats och har rätt namn)
        //Select används för att hämta namnen från rooms-listan
        Assert.Equal(expectedRoomNames, rooms.Select(room => room.Name));
        
    }

    [Fact]
    public void AddConnectedRoom_ShouldConnectRoomsCorrectly()
    {
        //Arrange (skapar två av rummen)
        var room1 = new Room("Röda rummet");
        var room2 = new Room("Blåa rummet");

        //Act (kopplar ihop rummen)
        room1.AddConnectedRoom(room2);

        //Assert (kollar så att rummen blivit kopplade)
        //Använder contains så att room2 är med i room1:s connectedRooms
        Assert.Contains(room2, room1.ConnectedRooms);
        //Kollar sen så att det bara är ett rum kopplat till room1
        Assert.Single(room1.ConnectedRooms);
    }
}