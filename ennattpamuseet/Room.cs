using System;

namespace ennattpamuseet;

public class Room
{
    public string  Name { get; private set; }
    //Skapar en lista för att kunna lägga till konsten i rummen
    public List<Artwork> artworks;
    public List<Room> ConnectedRooms { get; private set; }

    private static readonly List<(string fromRoom, string toRoom)> museumMap = new()
    {
        ("Entré", "Korridor"),
        ("Korridor", "Gröna rummet"),
        ("Gröna rummet", "Röda rummet"),
        ("Gröna rummet", "Blåa rummet"),
        ("Röda rummet", "Lila rummet"),
        ("Lila rummet", "Blåa rummet"),
        ("Blåa rummet", "Vita rummet"),
        ("Blåa rummet", "Svarta rummet")
    };
    public Room()
    {
       
    }

    public Room(string name)
    {
        Name = name;
        artworks = new List<Artwork>();
        ConnectedRooms = new List<Room>();
    }

    //Metod för att koppla samman rummen
    //Den kollar om rummen är kopplade, ifall det inte stämmer
    //läggs rummen in i ConnectedRoom
    public void AddConnectedRoom(Room room)
    {
        if (!ConnectedRooms.Contains(room))
        {
            ConnectedRooms.Add(room);
        }
    }


    //Metoden för att lägga till konstverken i rummeng
    public void AddArtwork(Artwork artwork)
    {
        artworks.Add(artwork);
    }

    //Metod som ska hämta de konstverk som finns i rummet
    public List<Artwork> GetArtworks()
    {
        return new List<Artwork>(artworks);
    }    

    //Metod för att skriva ut vilket rum du är i och vilka konstverk som finns i rummet
    //Den loopar genom alla konstverk och skriver ut infon som finns
    public void DisplayArtworksInRoom()
    {
       
        
        if (artworks.Any())
        {
            Console.WriteLine("\nDessa konstverk finns här:");
            foreach (var artwork in artworks)
            {
                artwork.DisplayArtInfo();
            }
        }
    }

    public static List<Room> CreateTheRooms()
    {
        var rooms = new List<Room>
        {
            new Room("Entré"),
            new Room("Korridor"),
            new Room("Gröna rummet"),
            new Room("Röda rummet"),
            new Room("Lila rummet"),
            new Room("Blåa rummet"),
            new Room("Svarta rummet"),
            new Room("Vita rummet")
        };

        // Tilldelar konstverken till rummen

        var artworkStorage = new ArtworkStorage();

        rooms.First(r => r.Name == "Vita rummet").AddArtwork(artworkStorage.Artworks[0]);

        rooms.First(r => r.Name == "Lila rummet").AddArtwork(artworkStorage.Artworks[1]);
        rooms.First(r => r.Name == "Lila rummet").AddArtwork(artworkStorage.Artworks[2]);
        rooms.First(r => r.Name == "Lila rummet").AddArtwork(artworkStorage.Artworks[3]);
        rooms.First(r => r.Name == "Lila rummet").AddArtwork(artworkStorage.Artworks[4]);

        rooms.First(r => r.Name == "Blåa rummet").AddArtwork(artworkStorage.Artworks[5]);

        rooms.First(r => r.Name == "Röda rummet").AddArtwork(artworkStorage.Artworks[6]);
        rooms.First(r => r.Name == "Röda rummet").AddArtwork(artworkStorage.Artworks[7]);
        rooms.First(r => r.Name == "Röda rummet").AddArtwork(artworkStorage.Artworks[8]);

        rooms.First(r => r.Name == "Gröna rummet").AddArtwork(artworkStorage.Artworks[9]);
        rooms.First(r => r.Name == "Gröna rummet").AddArtwork(artworkStorage.Artworks[10]);

        ConnectAllRooms(rooms);
        return rooms;
    }

    //Metoden för att koppla samman alla rummen
    //Den loopar genom alla rum och kopplar ihop dem utifrån museumMap(nämnd ovan)
    private static void ConnectAllRooms(List<Room> rooms)
    {
        foreach (var connection in museumMap)
        {
            var fromRoom = rooms.Find(r => r.Name == connection.fromRoom);
            var toRoom = rooms.Find(r => r.Name == connection.toRoom);

            //Kollar så båda rummen finns och kopplar ihop dom med varandra
            //Möjliggör att du kan flytta från ett rum och sen tillbaka till samma
            if (fromRoom != null && toRoom != null)
            {
                fromRoom.AddConnectedRoom(toRoom);
                toRoom.AddConnectedRoom(fromRoom);
            }
        }
    }
}

