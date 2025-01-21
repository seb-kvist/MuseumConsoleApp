using System.Collections.Generic;

public class ArtworkStorage
{
    public List<Artwork> Artworks { get; private set; }

    public ArtworkStorage()
    {
        Artworks = new List<Artwork>
        {
            // Tillhör Vita rummet
            new Artwork("Flygande drakar", "Färgglada drakar som svävar i luften", "Ella, 7 år"),

            // Tillhör Lila rummet  
            new Artwork("Min familj", "En glad teckning med fem färgglada figurer", "Emma, 7 år"),
            new Artwork("Dinosauriefest", "En stor T-Rex som dansar med kompisar", "Lucas, 6 år"),
            new Artwork("Regnbågsslottet", "Ett sagoslott med glitter och enhörningar", "Sofia, 8 år"),
            new Artwork("Superhjälten", "En färgglad superhjälte som flyger bland molnen", "Alex, 5 år"),
            
            // Tillhör Blåa rummet
            new Artwork("Havets vänner", "Glada fiskar och en sjöjungfru", "Noah, 6 år"),

            // Tillhör Röda rummet
            new Artwork("Min banan", "En gul banan", "William, 6 år"),
            new Artwork("Rymdäventyr", "Raketer och stjärnor i alla färger", "Maja, 7 år"),
            new Artwork("Godisregn", "Ett moln som regnar godis över glada barn", "William, 6 år"),
            
            // Tillhör Gröna rummet
            new Artwork("Gröna världen", "En väldigt grön värld med många växter och djur", "Ella, 7 år"),
            new Artwork("Snögubbefamiljen", "Tre snögubbar i vinterlandskap", "Hugo, 7 år") 
        };
    }

    public void AddArtwork(Artwork artwork)
    {
        Artworks.Add(artwork);
    }
}